using MoreBatons.Common;
using MoreBatons.Content.Batons.PearlBaton;
using Terraria.ModLoader;

namespace MoreBatons.Content.AntyBatons.CrunchyPeanutsAntyBaton
{
    public class CrunchyPeanutsAntyBaton : ABaton
    {
        public override int projectile() { return ModContent.ProjectileType<CrunchyPeanutsAntyBatonProjectile>(); }
        public override int damage() { return 25; }
        public override int sellPrice() { return 35; }
	    public override int baton() { return ModContent.ItemType<PearlBaton>(); }
		public override float healthCost() { return 0.05f; }
	}
}
