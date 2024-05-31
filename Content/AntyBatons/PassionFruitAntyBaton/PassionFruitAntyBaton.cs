using MoreBatons.Common;
using MoreBatons.Content.Batons.EbonBaton;
using Terraria.ModLoader;

namespace MoreBatons.Content.AntyBatons.PassionFruitAntyBaton
{
    public class PassionFruitAntyBaton : ABaton
    {
        public override int projectile() { return ModContent.ProjectileType<PassionFruitAntyBatonProjectile>(); }
        public override int damage() { return 8; }
        public override int sellPrice() { return 35; }
	    public override int baton() { return ModContent.ItemType<EbonBaton>(); }
		public override float healthCost() { return 0.03f; }
	}
}
