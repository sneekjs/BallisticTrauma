namespace JorritSlaats.BallisticTrauma.Scripts.Actors
{
    using JorritSlaats.BallisticTrauma.Scripts.Behaviours;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Actor : MonoBehaviour
    {
        [SerializeField]
        protected float _health;
        
        [SerializeField]
        protected DespawnBehaviour _despawnBehaviour;

        [SerializeField]
        protected TakeDamageBehaviour takeDamageBehaviour;
    }
}