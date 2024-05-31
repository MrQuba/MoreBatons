using MoreBatons.Common;
using MoreBatons.Content.Batons.LivingBaton;
using Terraria.ModLoader;
namespace MoreBatons.Content.AntyBatons.ChocoNutsAntyBaton
{
    public class ChocoNutsAntyBaton : ABaton
    {
        public override int projectile() { return ModContent.ProjectileType<ChocoNutsAntyBatonProjectile>(); }
        public override int damage() { return 5; }
        public override int sellPrice() { return 35; }
	    public override int baton() { return ModContent.ItemType<LivingBaton>(); }
		public override float healthCost() { return 0.025f; }
	}
}
