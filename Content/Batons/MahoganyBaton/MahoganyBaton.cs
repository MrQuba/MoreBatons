using Terraria.ID;
using MoreBatons.Common;
using Terraria.ModLoader;
using System.Numerics;

namespace MoreBatons.Content.Batons.MahoganyBaton
{
    public class MahoganyBaton : Baton
    {
        public override int projectile() { return ModContent.ProjectileType<MahoganyBatonProjectile>(); }
        public override int damage() { return 7; }
        public override int sellPrice() { return 30; }
        public override int tile() { return TileID.WorkBenches; }
        public override Vector2 ingredients() { return new Vector2(ItemID.RichMahogany, 8); }

    }
}
