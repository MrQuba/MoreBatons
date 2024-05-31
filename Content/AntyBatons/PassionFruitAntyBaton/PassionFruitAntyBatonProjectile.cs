using MoreBatons.Common;
using Terraria;

namespace MoreBatons.Content.AntyBatons.PassionFruitAntyBaton
{
    public class PassionFruitAntyBatonProjectile : ABatonProjectile
    {
        public override int penetrate()  { return -1; }
		public override float healAmount() {
			if (Main.LocalPlayer.GetModPlayer<BatonPlayer>().passionFruitAttackCounter == 4)
			{
				Main.LocalPlayer.GetModPlayer<BatonPlayer>().passionFruitAttackCounter = 0;
				return 0.03f;
			}
			else Main.LocalPlayer.GetModPlayer<BatonPlayer>().passionFruitAttackCounter += 1;
			return 0;
		}
		public override void SafeOnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
		{
		}
	}
}

