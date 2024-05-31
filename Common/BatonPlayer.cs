using MoreBatons.Content.Batons.EbonBaton;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace MoreBatons.Common
{
	public class BatonPlayer : ModPlayer
	{
		public int ebonBatonAttackCounter = 0;
		public int passionFruitAttackCounter = 0;
			public List<int> GetListOfPrefixes(int item)
			{
				List<int> prefixes = new();

				foreach (Item Item in Player.inventory)
				{
					if (Item == null || Item.IsAir)
					{
						continue;
					}

					if (Item.type == item)
					{
						prefixes.Add(Item.prefix);
					}
				}
				return prefixes;
			}

			public bool CheckForPrefix(List<int> list, int prefixType)
			{

				if (list == null || list.Count == 0)
				{
					return false;
				}

				bool exists = list.Contains(prefixType);
				return exists;
			}
	}
}
