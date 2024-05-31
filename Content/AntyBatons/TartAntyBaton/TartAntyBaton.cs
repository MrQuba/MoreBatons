using MoreBatons.Common;
using MoreBatons.Content.Batons.ShadeBaton;
using Terraria.ModLoader;

namespace MoreBatons.Content.AntyBatons.TartAntyBaton
{
    public class TartAntyBaton : ABaton
    {
        public override int projectile() { return ModContent.ProjectileType<TartAntyBatonProjectile>(); }
        public override int damage() { return 8; }
        public override int sellPrice() { return 35; }
	    public override int baton() { return ModContent.ItemType<ShadeBaton>(); }
		public override float healthCost() { return 0.025f; }
	}
}
