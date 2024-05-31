using Terraria.ID;
using MoreBatons.Common;
using Terraria.ModLoader;
using System.Numerics;
using ThoriumMod.Items.SummonItems;

namespace MoreBatons.Content.Batons.LivingBaton
{
    public class LivingBaton : Baton
    {
        public override int projectile() { return ModContent.ProjectileType<LivingBatonProjectile>(); }
        public override int damage() { return 8; }
        public override int sellPrice() { return 30; }
        public override int tile() { return TileID.LivingLoom; }
        public override Vector2 ingredients() { return new Vector2(ItemID.Wood, 8); }
        public override Vector2 ingredients2() { return new Vector2(ModContent.ItemType<LivingLeaf>(), 3); }

    }
}
