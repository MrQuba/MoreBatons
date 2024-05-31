using Terraria;
using Terraria.ID;
using MoreBatons.Common;
using Microsoft.Xna.Framework;

namespace MoreBatons.Content.Batons.YewBaton
{
    public class YewBatonProjectile : BatonProjectile
    {
        public override void SafeOnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
            Projectile.NewProjectile(Projectile.GetSource_OnHit(target), target.position, Vector2.One, ProjectileID.SpikyBall, 10, 2f);
        }
        public override void OnHitPlayer(Player target, Player.HurtInfo info)
		{
			Projectile.NewProjectile(Projectile.GetSource_OnHit(target), target.position, Vector2.One, ProjectileID.SpikyBall, 10, 2f);
		}
    }
}

