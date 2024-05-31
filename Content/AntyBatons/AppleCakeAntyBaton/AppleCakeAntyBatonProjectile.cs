using MoreBatons.Common;
using Terraria;
using Terraria.ID;

namespace MoreBatons.Content.AntyBatons.AppleCakeAntyBaton
{
    public class AppleCakeAntyBatonProjectile : ABatonProjectile
    {
        public override int penetrate()  { return 1; }
		public override float healAmount() { return 0.025f; }
		public override void SafeOnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
		{
			target.AddBuff(BuffID.Poisoned, 350);
		}
		public override void OnHitPlayer(Player target, Player.HurtInfo info)
		{
			target.AddBuff(BuffID.Poisoned, 350);
		}
	}
}

