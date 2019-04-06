namespace JorritSlaats.BallisticTrauma.Scripts.Actors
{
    using JorritSlaats.BallisticTrauma.Scripts.Behaviours;
    using JorritSlaats.BallisticTrauma.Scripts.Weapons;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Player : MovingActor
    {
        [SerializeField]
        private Camera _camera;

        [SerializeField]
        private TargetBehaviour _targetBehaviour;

        [SerializeField]
        private Weapon _weapon;

        [SerializeField]
        private int _jumpAmount;

        [SerializeField]
        private float _jumpHeight;

        [SerializeField]
        private float _luck;

        public Camera Camera
        {
            get { return _camera; }
            private set { _camera = value; }
        }

        private void Update()
        {
            _targetBehaviour.Target((Player)this);
            if (Input.GetButtonDown("Fire1"))
            {
                FireWeapon();
            }
        }

        private void FixedUpdate()
        {
            _movementBehaviour.Move(this);
        }

        private void FireWeapon()
        {
            _weapon.Fire();
        }
    }
}