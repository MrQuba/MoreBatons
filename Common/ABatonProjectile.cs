using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ThoriumMod;
using ThoriumMod.Utilities;

namespace MoreBatons.Common
{
	public abstract class ABatonProjectile : ModProjectile
	{
		public abstract int penetrate();
		public abstract float healAmount();
		private void HealPlayer(Player p)
		{
			p.HealLife((int)(p.statLifeMax * healAmount() + 1), p);
		}
		public sealed override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
		{
			Player player = Main.player[Projectile.owner];
			foreach(Player teammate in Main.player)
			{
				if(player.team == teammate.team)
				{
					HealPlayer(teammate);
				}
			}
			SafeOnHitNPC(target, hit, damageDone);
		}
		public abstract void SafeOnHitNPC(NPC target, NPC.HitInfo hit, int damageDone);
		public override void SetDefaults()
		{
			Projectile.CloneDefaults(ProjectileID.WaterStream);
			Projectile.DamageType = ThoriumDamageBase<HealerDamage>.Instance;
			Projectile.aiStyle = ProjAIStyleID.Stream;
			Projectile.penetrate = penetrate(); 
		}
	}
}
