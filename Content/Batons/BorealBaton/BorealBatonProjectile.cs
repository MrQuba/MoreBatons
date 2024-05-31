using Terraria;
using Terraria.ID;
using MoreBatons.Common;

namespace MoreBatons.Content.Batons.BorealBaton
{
    public class BorealBatonProjectile : BatonProjectile
    {
        public override void SafeOnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
            target.AddBuff(BuffID.Frostburn, 300);
        }
        public override void OnHitPlayer(Player target, Player.HurtInfo info)
        {
            target.AddBuff(BuffID.Frostburn, 300);

        }
    }
}

