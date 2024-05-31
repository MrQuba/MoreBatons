using MoreBatons.Common;
using Terraria;
using Terraria.ID;

namespace MoreBatons.Content.AntyBatons.ChocoNutsAntyBaton
{
    public class ChocoNutsAntyBatonProjectile : ABatonProjectile
    {
        public override int penetrate()  { return 1; }
		public override float healAmount() { return 0.025f; }
		public override void SafeOnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
		{
			Projectile.NewProjectile(Projectile.GetSource_OnHit(Projectile), Projectile.Center, Projectile.velocity, ProjectileID.Leaf, Projectile.damage, Projectile.knockBack, Projectile.owner);
		}
		public override void OnHitPlayer(Player target, Player.HurtInfo info)
		{
			if (Main.rand.Next(0, 1000) <= 150)
				target.AddBuff(BuffID.Confused, 150);
			base.OnHitPlayer(target, info);
		}
	}
}

