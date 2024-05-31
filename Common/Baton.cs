
using System.Numerics;
using Terraria;
using Terraria.ID;
using ThoriumMod;
using ThoriumMod.Items.HealerItems;

namespace MoreBatons.Common
{
	public abstract class Baton : ScytheItem
	{
		public override void SetStaticDefaults()
		{
			SetStaticDefaultsToScythe();
		}
		public abstract int sellPrice();
		public abstract int damage();
		public abstract int projectile();
		public override void SetDefaults()
		{
			SetDefaultsToScythe();
			Item.DamageType = ThoriumDamageBase<HealerDamage>.Instance;
			isHealer = true;
			Item.width = 36;
			Item.height = 36;
			Item.rare = ItemRarityID.White;
			Item.sellPrice(copper: sellPrice());
			Item.damage = damage();
			Item.shoot = projectile();
		}
		public abstract Vector2 ingredients();
		public virtual Vector2 ingredients2()
		{
			return Vector2.Zero;
		}
		public abstract int tile();
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient((int)ingredients().X, (int)ingredients().Y);
			if (ingredients2().X != 0)
			{
				recipe.AddIngredient((int)ingredients2().X, (int)ingredients2().Y);
			}
				recipe.AddTile(tile())
				.Register();
		}
	}
}
