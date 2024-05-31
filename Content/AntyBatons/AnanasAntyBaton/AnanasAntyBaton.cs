using MoreBatons.Common;
using MoreBatons.Content.Batons.PalmBaton;
using Terraria.ModLoader;

namespace MoreBatons.Content.AntyBatons.AnanasAntyBaton
{
    public class AnanasAntyBaton : ABaton
    {
        public override int projectile() { return ModContent.ProjectileType<AnanasAntyBatonProjectile>(); }
        public override int damage() { return 7; }
        public override int sellPrice() { return 35; }
	    public override int baton() { return ModContent.ItemType<PalmBaton>(); }
		public override float healthCost() { return 0.025f; }
	}
}
