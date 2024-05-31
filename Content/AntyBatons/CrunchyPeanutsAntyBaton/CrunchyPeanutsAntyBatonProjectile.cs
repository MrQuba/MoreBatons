using MoreBatons.Common;
using Terraria;

namespace MoreBatons.Content.AntyBatons.CrunchyPeanutsAntyBaton
{
    public class CrunchyPeanutsAntyBatonProjectile : ABatonProjectile
    {
        public override int penetrate()  { return 1; }
		public override float healAmount() { return 0.05f; }
		public override void SafeOnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
		{
		}
	}
}

