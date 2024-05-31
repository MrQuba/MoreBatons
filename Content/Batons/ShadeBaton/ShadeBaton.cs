using Terraria.ID;
using MoreBatons.Common;
using Terraria.ModLoader;
using System.Numerics;

namespace MoreBatons.Content.Batons.ShadeBaton
{
    public class ShadeBaton : Baton
    {
        public override int projectile() { return ModContent.ProjectileType<ShadeBatonProjectile>(); }
        public override int damage() { return 8; }
        public override int sellPrice() { return 30; }
        public override int tile() { return TileID.WorkBenches; }
        public override Vector2 ingredients() { return new Vector2(ItemID.Shadewood, 8); }

    }
}
