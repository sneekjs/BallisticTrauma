namespace JorritSlaats.BallisticTrauma.Scripts.Actors
{
    using JorritSlaats.BallisticTrauma.Scripts.Behaviours;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    [RequireComponent(typeof(Rigidbody))]
    public class Actor : MonoBehaviour
    {
        [SerializeField]
        protected float _health;
        
        [SerializeField]
        protected DespawnBehaviour _despawnBehaviour;

        [SerializeField]
        protected TakeDamageBehaviour takeDamageBehaviour;

        private Rigidbody rigidbody1;

        public Rigidbody Rigidbody
        {
            get { return rigidbody1; }
            set { rigidbody1 = value; }
        }

        protected virtual void Start()
        {
            Rigidbody = gameObject.GetComponent<Rigidbody>();
        }
    }
}