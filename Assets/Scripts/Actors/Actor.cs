namespace JorritSlaats.BallisticTrauma.Scripts.Actors
{
    using JorritSlaats.BallisticTrauma.Scripts.Behaviours;
    using JorritSlaats.BallisticTrauma.Scripts.Behaviours.DespawnBehaviours;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    [RequireComponent(typeof(Rigidbody))]
    public class Actor : MonoBehaviour
    {
        [SerializeField]
        private float _maxHealth;

        [SerializeField]
        private float _currentHealth;
        
        [SerializeField]
        private DespawnBehaviour _despawnBehaviour;

        [SerializeField]
        private TakeDamageBehaviour _takeDamageBehaviour;

        private Rigidbody rigidbody1;

        public Rigidbody Rigidbody
        {
            get { return rigidbody1; }
            set { rigidbody1 = value; }
        }

        public TakeDamageBehaviour TakeDamageBehaviour
        {
            get { return _takeDamageBehaviour; }
            set { _takeDamageBehaviour = value; }
        }

        public float MaxHealth
        {
            get { return _maxHealth; }
            set { _maxHealth = value; }
        }

        public float CurrentHealth
        {
            get { return _currentHealth; }
            set { _currentHealth = value; }
        }

        public DespawnBehaviour DespawnBehaviour
        {
            get { return _despawnBehaviour; }
            set { _despawnBehaviour = value; }
        }

        protected virtual void Start()
        {
            Rigidbody = gameObject.GetComponent<Rigidbody>();
            CurrentHealth = MaxHealth;
        }
    }
}