using Terraria;
using Terraria.ID;
using MoreBatons.Common;
using System;

namespace MoreBatons.Content.Batons.MahoganyBaton
{
    public class MahoganyBatonProjectile : BatonProjectile
    {
        public override void SafeOnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
            target.AddBuff(BuffID.Poisoned, 450);
        }
        public override void OnHitPlayer(Player target, Player.HurtInfo info)
        {
            target.AddBuff(BuffID.Poisoned, 350);

        }
    }
}

