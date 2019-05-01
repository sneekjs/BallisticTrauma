namespace JorritSlaats.BallisticTrauma.Scripts.Behaviours.DespawnBehaviours
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public abstract class DespawnBehaviour : MonoBehaviour
    {
        public abstract void CheckDespawn();

        public abstract void CheckDespawn(Collider collider, float bulletDamage);
    }
}