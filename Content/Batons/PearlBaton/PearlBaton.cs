using Terraria.ID;
using MoreBatons.Common;
using Terraria.ModLoader;
using System.Numerics;

namespace MoreBatons.Content.Batons.PearlBaton
{
    public class PearlBaton : Baton
    {
        public override int projectile() { return ModContent.ProjectileType<PearlBatonProjectile>(); }
        public override int damage() { return 23; }
        public override int sellPrice() { return 50; }
        public override int tile() { return TileID.MythrilAnvil; }
        public override Vector2 ingredients() { return new Vector2(ItemID.Pearlwood, 8); }

    }
}
