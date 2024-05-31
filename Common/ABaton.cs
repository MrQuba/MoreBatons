using System;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using ThoriumMod;
using ThoriumMod.Items;

namespace MoreBatons.Common
{
	public abstract class ABaton : ThoriumItem
	{
		public abstract int damage();
		public abstract int sellPrice();
		public abstract int projectile();
		public abstract float healthCost();
		public abstract int baton();
		public override void SetDefaults()
		{
			Item.CloneDefaults(ItemID.AquaScepter);
			healType = HealType.AllyAndPlayer;
			healAmount = 1;
			healDisplay = true;
			isHealer = true;
			Item.damage = damage();
			Item.DamageType = ThoriumDamageBase<HealerDamage>.Instance;
			Item.sellPrice(copper: sellPrice());
			Item.width = 38;
			Item.height = 38;
			Item.shoot = projectile();
			Item.mana = 0;

		}
		public override bool? UseItem(Player player)
		{
			if(player.whoAmI == Main.myPlayer)
			{
				healAmount = ((int)(healthCost() * player.statLifeMax)) + 1;
				player.Heal(-(healAmount - 1));
			}
			return true;
		}
		public LocalizedText conditionDescription => Language.GetOrRegister("Mods.MoreBatons.Common.BatonCondition");
		public override void AddRecipes()
		{
			Player player = Main.LocalPlayer;
			Recipe recipe = CreateRecipe()
			.AddIngredient(baton())
			.AddTile(TileID.WorkBenches)
			.AddCondition(Condition.InAether)
			.AddCondition(conditionDescription, () =>
			{
				try
				{
					var player = Main.LocalPlayer;
					var batonPlayer = player.GetModPlayer<BatonPlayer>();

					var prefixes = batonPlayer.GetListOfPrefixes(baton());

					bool hasPrefix = batonPlayer.CheckForPrefix(prefixes, PrefixID.Broken);

					return hasPrefix;
				}
				catch (Exception ex)
				{
					Main.NewText("Exception in recipe condition: " + ex.Message);
					return false;
				}
			})
			.Register();
		}
	}
}
