using Terraria.ID;
using MoreBatons.Common;
using Terraria.ModLoader;
using System.Numerics;

namespace MoreBatons.Content.Batons.EbonBaton
{
    public class EbonBaton : Baton
    {
        public override int projectile() { return ModContent.ProjectileType<EbonBatonProjectile>(); }
        public override int damage() { return 8; }
        public override int sellPrice() { return 30; }
        public override int tile() { return TileID.WorkBenches; }
        public override Vector2 ingredients() { return new Vector2(ItemID.Ebonwood, 8); }

    }
}
