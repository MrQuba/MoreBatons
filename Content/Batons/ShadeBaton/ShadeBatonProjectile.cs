using Terraria;
using Terraria.ID;
using MoreBatons.Common;
using System;

namespace MoreBatons.Content.Batons.ShadeBaton
{
    public class ShadeBatonProjectile : BatonProjectile
    {
        public override void SafeOnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
            if (Main.rand.Next(0, 1000) <= 150)
                target.AddBuff(BuffID.Confused, 150);
        }
        public override void OnHitPlayer(Player target, Player.HurtInfo info)
        {
            if (Main.rand.Next(0, 1000) <= 150)
                target.AddBuff(BuffID.Confused, 150);

        }
    }
}

