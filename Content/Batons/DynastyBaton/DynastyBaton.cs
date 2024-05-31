using Terraria.ID;
using MoreBatons.Common;
using Terraria.ModLoader;
using System.Numerics;

namespace MoreBatons.Content.Batons.DynastyBaton
{
    public class DynastyBaton : Baton
    {
        public override int projectile() { return ModContent.ProjectileType<DynastyBatonProjectile>(); }
        public override int damage() { return 19; }
        public override int sellPrice() { return 30; }
        public override int tile() { return TileID.WorkBenches; }
        public override Vector2 ingredients() { return new Vector2(ItemID.DynastyWood, 8); }

    }
}
