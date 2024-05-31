using MoreBatons.Common;
using Terraria.ModLoader;
using ThoriumMod.Items.HealerItems;

namespace MoreBatons.Content.AntyBatons.MangoAntyBaton
{
    public class MangoAntyBaton : ABaton
    {
        public override int projectile() { return ModContent.ProjectileType<MangoAntyBatonProjectile>(); }
        public override int damage() { return 5; }
        public override int sellPrice() { return 35; }
	    public override int baton() { return ModContent.ItemType<WoodenBaton>(); }
		public override float healthCost() { return 0.025f; }
	}
}
