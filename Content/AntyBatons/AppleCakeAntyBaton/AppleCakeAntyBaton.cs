using MoreBatons.Common;
using MoreBatons.Content.Batons.MahoganyBaton;
using Terraria.ModLoader;

namespace MoreBatons.Content.AntyBatons.AppleCakeAntyBaton
{
    public class AppleCakeAntyBaton : ABaton
    {
        public override int projectile() { return ModContent.ProjectileType<AppleCakeAntyBatonProjectile>(); }
        public override int damage() { return 7; }
        public override int sellPrice() { return 35; }
	    public override int baton() { return ModContent.ItemType<MahoganyBaton>(); }
		public override float healthCost() { return 0.025f; }
	}
}
