using Terraria;
using Terraria.ID;
using MoreBatons.Common;
using System;

namespace MoreBatons.Content.Batons.LivingBaton
{
    public class LivingBatonProjectile : BatonProjectile
    {
        public override void SafeOnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
            Projectile.NewProjectile(Projectile.GetSource_OnHit(Projectile), Projectile.Center, Projectile.velocity, ProjectileID.Leaf, Projectile.damage, Projectile.knockBack, Projectile.owner);
        }
        public override void OnHitPlayer(Player target, Player.HurtInfo info)
        {
            if (Main.rand.Next(0, 1000) <= 150)
                target.AddBuff(BuffID.Confused, 150);

        }
    }
}

