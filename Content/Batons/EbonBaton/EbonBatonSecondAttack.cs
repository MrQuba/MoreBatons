using Terraria.ID;
using Terraria.ModLoader;
using ThoriumMod;

namespace MoreBatons.Content.Batons.EbonBaton
{
    public class EbonBatonSecondAttack : ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.CloneDefaults(ProjectileID.SuperStarSlash);
            Projectile.DamageType = ThoriumDamageBase<HealerDamage>.Instance;
            Projectile.damage = 10;
            Projectile.aiStyle = ProjAIStyleID.SuperStarBeam;
        }
    }
}
