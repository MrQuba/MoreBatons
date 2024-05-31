using Microsoft.Xna.Framework;
using MoreBatons.Common;
using Terraria;
using Terraria.ID;

namespace MoreBatons.Content.AntyBatons.CrunchyWaferAntyBaton
{
    public class CrunchyWaferAntyBatonProjectile : ABatonProjectile
    {
        public override int penetrate()  { return 1; }
		public override float healAmount() { return 0.025f; }
		public override void SafeOnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
		{
			Projectile.NewProjectile(Projectile.GetSource_OnHit(target), target.position, Vector2.One, ProjectileID.SpikyBall, 10, 2f);
			target.AddBuff(BuffID.ShadowFlame, 150);
		}
		public override void OnHitPlayer(Player target, Player.HurtInfo info)
		{
			Projectile.NewProjectile(Projectile.GetSource_OnHit(target), target.position, Vector2.One, ProjectileID.SpikyBall, 10, 2f);
			target.AddBuff(BuffID.ShadowFlame, 150);
		}
	}
}

