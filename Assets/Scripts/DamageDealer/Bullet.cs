namespace JorritSlaats.BallisticTrauma.Scripts.DamageDealer
{
    using JorritSlaats.BallisticTrauma.Scripts.Actors;
    using JorritSlaats.BallisticTrauma.Scripts.Behaviours.DespawnBehaviours;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    [RequireComponent(typeof(Rigidbody))]
    public class Bullet : DamageDealer
    {
        [SerializeField]
        private float _speed;

        [SerializeField]
        private DespawnBehaviour _despawnBehaviour;

        private Rigidbody _rigidbody;

        private void Start()
        {
            Rigidbody = GetComponent<Rigidbody>();
        }

        protected float Speed
        {
            get { return _speed; }
            private set { _speed = value; }
        }

        protected Rigidbody Rigidbody
        {
            get { return _rigidbody; }
            private set { _rigidbody = value; }
        }

        private void OnTriggerEnter(Collider collider)
        {
            _despawnBehaviour.CheckDespawn(collider, _damage);

            Player player = collider.gameObject.GetComponent<Player>();
            if (_canHitPlayer && player != null)
            {
                player.TakeDamageBehaviour.TakeDamage(player, _damage);
            }
        }
    }
}