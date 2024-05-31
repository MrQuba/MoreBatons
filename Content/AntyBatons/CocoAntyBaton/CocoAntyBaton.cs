using MoreBatons.Common;
using MoreBatons.Content.Batons.DynastyBaton;
using Terraria.ModLoader;

namespace MoreBatons.Content.AntyBatons.CocoAntyBaton
{
    public class CocoAntyBaton : ABaton
    {
        public override int projectile() { return ModContent.ProjectileType<CocoAntyBatonProjectile>(); }
        public override int damage() { return 17; }
        public override int sellPrice() { return 35; }
	    public override int baton() { return ModContent.ItemType<DynastyBaton>(); }
		public override float healthCost() { return 0.025f; }
	}
}
