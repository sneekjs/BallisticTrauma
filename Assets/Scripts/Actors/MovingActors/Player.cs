namespace JorritSlaats.BallisticTrauma.Scripts.Actors
{
    using JorritSlaats.BallisticTrauma.Scripts.Weapons;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Player : MovingActor
    {
        [SerializeField]
        private Weapon _weapon;

        [SerializeField]
        private int _jumpAmount;

        [SerializeField]
        private float _jumpHeight;

        [SerializeField]
        private float _luck;

        private void Update()
        {
            _movementBehaviour.Move(this);
        }
    }
}