using Terraria.ID;
using MoreBatons.Common;
using Terraria.ModLoader;
using System.Numerics;
using ThoriumMod.Items.ArcaneArmor;

namespace MoreBatons.Content.Batons.YewBaton
{
    public class YewBaton : Baton
    {
        public override int projectile() { return ModContent.ProjectileType<YewBatonProjectile>(); }
        public override int damage() { return 10; }
        public override int sellPrice() { return 25; }
        public override int tile() { return TileID.WorkBenches; }
        public override Vector2 ingredients() { return new Vector2(ModContent.ItemType<YewWood>(), 8); }
		public override Vector2 ingredients2() { return new Vector2(ItemID.SpikyBall, 32); }

	}
}
