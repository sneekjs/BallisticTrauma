namespace JorritSlaats.BallisticTrauma.Scripts.Actors
{
    using JorritSlaats.BallisticTrauma.Scripts.Behaviours;
    using JorritSlaats.BallisticTrauma.Scripts.UI;
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

        [SerializeField]
        private GameObject _feetPosition;

        private PlayerUI _playerUI;

        private int _remainingJumps;

        private bool _canResetJumps;

        public Camera Camera
        {
            get { return _camera; }
            private set { _camera = value; }
        }

        public PlayerUI PlayerUI
        {
            get { return _playerUI; }
            set { _playerUI = value; }
        }

        protected override void Start()
        {
            base.Start();

            _remainingJumps = _jumpAmount;

            PlayerUI = FindObjectOfType<PlayerUI>();
            PlayerUI.UpdateHealthBar(this);
        }

        private void Update()
        {
            _targetBehaviour.Target((Player)this);
            if (Input.GetButtonDown("Fire1"))
            {
                FireWeapon();
            }
            if (Input.GetButtonDown("Jump") && _remainingJumps > 0)
            {
                Jump();
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

        private void Jump()
        {
            _canResetJumps = false;
            Invoke("AllowJumpReset", 0.3f);

            _remainingJumps--;
            Rigidbody.velocity = new Vector3(Rigidbody.velocity.x, 0, Rigidbody.velocity.z);
            Rigidbody.AddForce(0, _jumpHeight, 0, ForceMode.Impulse);
        }

        private void CheckJumpReset()
        {
            if (_remainingJumps != _jumpAmount && _canResetJumps)
            {
                RaycastHit hit;
                Ray myRay = new Ray(_feetPosition.transform.position, _feetPosition.transform.TransformDirection(Vector3.down));

                if (Physics.Raycast(myRay, out hit, 0.2f))
                {
                    if (hit.collider != null)         // Checks if you are hitting the Ground
                    {
                        _remainingJumps = _jumpAmount;
                    }
                }
            }
        }

        private void AllowJumpReset()
        {
            _canResetJumps = true;
        }

        void OnCollisionStay(Collision collision)
        {
            CheckJumpReset();
        }

        private void OnCollisionEnter(Collision collision)
        {
            CheckJumpReset();
        }
    }
}