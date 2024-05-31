using Microsoft.Xna.Framework;
using ThoriumMod.Projectiles.Scythe;

namespace MoreBatons.Common
{
	public abstract class BatonProjectile : ScythePro
	{
		public override void SafeSetDefaults()
		{
			Projectile.Size = new Vector2(76f);
			Projectile.idStaticNPCHitCooldown = 20;
		}
	}
}
