using Terraria.ID;
using MoreBatons.Common;
using Terraria.ModLoader;
using System.Numerics;

namespace MoreBatons.Content.Batons.PalmBaton
{
    public class PalmBaton : Baton
    {
        public override int projectile() { return ModContent.ProjectileType<PalmBatonProjectile>(); }
        public override int damage() { return 7; }
        public override int sellPrice() { return 20; }
        public override int tile() { return TileID.WorkBenches; }
        public override Vector2 ingredients() { return new Vector2(ItemID.PalmWood, 8); }

    }
}
