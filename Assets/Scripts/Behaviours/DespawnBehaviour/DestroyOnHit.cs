namespace JorritSlaats.BallisticTrauma.Scripts.Behaviours.DespawnBehaviours
{
    using JorritSlaats.BallisticTrauma.Scripts.Actors;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class DestroyOnHit : DespawnBehaviour
    {
        public override void CheckDespawn()
        {
            throw new System.NotImplementedException();
        }

        public override void CheckDespawn(Collider collider, float bulletDamage)
        {
            if (collider.gameObject.GetComponent<Player>())
            {
                Destroy(gameObject);
            }
        }
    }
}