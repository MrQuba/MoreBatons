using MoreBatons.Common;
using Terraria;

namespace MoreBatons.Content.AntyBatons.MangoAntyBaton
{
    public class MangoAntyBatonProjectile : ABatonProjectile
    {
        public override int penetrate()  { return 1; }
		public override float healAmount() { return 0.025f; }
		public override void SafeOnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
		{
		}
	}
}

