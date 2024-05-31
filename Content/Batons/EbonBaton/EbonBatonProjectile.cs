using Terraria;
using Terraria.ID;
using MoreBatons.Common;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace MoreBatons.Content.Batons.EbonBaton
{
    public class EbonBatonProjectile : BatonProjectile
    {
        public override void SafeOnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
            if(Main.LocalPlayer.GetModPlayer<BatonPlayer>().ebonBatonAttackCounter == 4)
            {
                Main.LocalPlayer.GetModPlayer<BatonPlayer>().ebonBatonAttackCounter = 0;
				Projectile.NewProjectile(Projectile.GetSource_OnHit(target), new Vector2(target.position.X, target.position.Y + 5), new Vector2(5f), ModContent.ProjectileType<EbonBatonSecondAttack>(), 10, 6);
			}
            else
			{
				Main.LocalPlayer.GetModPlayer<BatonPlayer>().ebonBatonAttackCounter += 1;
			}
        }
        public override void OnHitPlayer(Player target, Player.HurtInfo info)
        {
            Projectile.NewProjectile(Projectile.GetSource_OnHit(target), new Vector2(target.position.X, target.position.Y + 5), new Vector2(5f), ModContent.ProjectileType<EbonBatonSecondAttack>(), 10, 6);
        }
    }
}

