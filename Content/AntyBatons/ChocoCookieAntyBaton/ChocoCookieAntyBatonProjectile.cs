using MoreBatons.Common;
using Terraria;
using Terraria.ID;

namespace MoreBatons.Content.AntyBatons.ChocoCookieAntyBaton
{
    public class ChocoCookieAntyBatonProjectile : ABatonProjectile
    {
        public override int penetrate()  { return 3; }
		public override float healAmount() { return 0.01f; }
		public override void SafeOnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
		{
			target.AddBuff(BuffID.OnFire, 300);
		}
		public override void OnHitPlayer(Player target, Player.HurtInfo info)
		{
			target.AddBuff(BuffID.OnFire, 300);
		}
	}
}

