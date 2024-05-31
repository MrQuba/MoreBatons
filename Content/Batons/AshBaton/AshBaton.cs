using Terraria.ID;
using MoreBatons.Common;
using Terraria.ModLoader;
using System.Numerics;

namespace MoreBatons.Content.Batons.AshBaton
{
    public class AshBaton : Baton
    {
        public override int projectile() { return ModContent.ProjectileType<AshBatonProjectile>(); }
        public override int damage() { return 15; }
        public override int sellPrice() { return 35; }
        public override int tile() { return TileID.WorkBenches; }
        public override Vector2 ingredients() { return new Vector2(ItemID.AshWood, 8); }

    }
}
