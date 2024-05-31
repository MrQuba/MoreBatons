using Terraria.ID;
using MoreBatons.Common;
using Terraria.ModLoader;
using System.Numerics;

namespace MoreBatons.Content.Batons.BorealBaton
{
    public class BorealBaton : Baton
    {
        public override int projectile() { return ModContent.ProjectileType<BorealBatonProjectile>(); }
        public override int damage() { return 6; }
        public override int sellPrice() { return 25; }
        public override int tile() { return TileID.WorkBenches; }
        public override Vector2 ingredients() { return new Vector2(ItemID.BorealWood, 8); }

    }
}
