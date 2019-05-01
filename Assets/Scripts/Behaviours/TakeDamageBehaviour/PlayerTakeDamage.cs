namespace JorritSlaats.BallisticTrauma.Scripts.Behaviours.TakeDamageBehaviours
{
    using JorritSlaats.BallisticTrauma.Scripts.Actors;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class PlayerTakeDamage : TakeDamageBehaviour
    {
        public override void TakeDamage(Actor actor, float damage)
        {
            base.TakeDamage(actor, damage);
            Player player = actor.gameObject.GetComponent<Player>();
            player.PlayerUI.UpdateHealthBar(player);


        }
    }
}