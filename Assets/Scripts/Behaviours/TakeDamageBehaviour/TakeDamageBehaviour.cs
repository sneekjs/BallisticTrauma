namespace JorritSlaats.BallisticTrauma.Scripts.Behaviours.TakeDamageBehaviours
{
    using JorritSlaats.BallisticTrauma.Scripts.Actors;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class TakeDamageBehaviour : MonoBehaviour
    {
        public virtual void TakeDamage(Actor actor, float damage)
        {
            actor.CurrentHealth -= damage;
            actor.CurrentHealth = Mathf.Clamp(actor.CurrentHealth, 0, actor.MaxHealth);

            if (actor.CurrentHealth == 0)
            {
                //actor.DespawnBehaviour.CheckDespawn();
            }
        }
    }
}