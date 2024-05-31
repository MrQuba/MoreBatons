using MoreBatons.Common;
using MoreBatons.Content.Batons.YewBaton;
using Terraria.ModLoader;

namespace MoreBatons.Content.AntyBatons.CrunchyWaferAntyBaton
{
    public class CrunchyWaferAntyBaton : ABaton
    {
        public override int projectile() { return ModContent.ProjectileType<CrunchyWaferAntyBatonProjectile>(); }
        public override int damage() { return 8; }
        public override int sellPrice() { return 35; }
	    public override int baton() { return ModContent.ItemType<YewBaton>(); }
		public override float healthCost() { return 0.025f; }
	}
}
