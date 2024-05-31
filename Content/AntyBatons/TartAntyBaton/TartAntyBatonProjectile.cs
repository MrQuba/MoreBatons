using MoreBatons.Common;
using Terraria;
using Terraria.ID;

namespace MoreBatons.Content.AntyBatons.TartAntyBaton
{
    public class TartAntyBatonProjectile : ABatonProjectile
    {
        public override int penetrate()  { return 1; }
		public override float healAmount() { return 0.025f; }
		public override void SafeOnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
		{
			if (Main.rand.Next(0, 1000) <= 150)
				target.AddBuff(BuffID.Confused, 150);

		}
		public override void OnHitPlayer(Player target, Player.HurtInfo info)
		{
			if (Main.rand.Next(0, 1000) <= 150)
				target.AddBuff(BuffID.Confused, 150);
		}
	}
}

