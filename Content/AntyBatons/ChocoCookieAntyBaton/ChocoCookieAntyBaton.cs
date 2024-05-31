using MoreBatons.Common;
using MoreBatons.Content.Batons.AshBaton;
using Terraria.ModLoader;

namespace MoreBatons.Content.AntyBatons.ChocoCookieAntyBaton
{
    public class ChocoCookieAntyBaton : ABaton
    {
        public override int projectile() { return ModContent.ProjectileType<ChocoCookieAntyBatonProjectile>(); }
        public override int damage() { return 15; }
        public override int sellPrice() { return 35; }
	    public override int baton() { return ModContent.ItemType<AshBaton>(); }
		public override float healthCost() { return 0.01f; }
	}
}
