using MoreBatons.Common;
using MoreBatons.Content.Batons.BorealBaton;
using Terraria.ModLoader;
namespace MoreBatons.Content.AntyBatons.CrunchyCoconutsAntyBaton
{
    public class CrunchyCoconutsAntyBaton : ABaton
    {
        public override int projectile() { return ModContent.ProjectileType<CrunchyCoconutsAntyBatonProjectile>(); }
        public override int damage() { return 6; }
        public override int sellPrice() { return 35; }
		public override int baton() { return ModContent.ItemType<BorealBaton>(); }
		public override float healthCost() { return 0.015f; }
	}
}
