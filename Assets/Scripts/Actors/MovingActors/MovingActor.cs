namespace JorritSlaats.BallisticTrauma.Scripts.Actors
{
    using JorritSlaats.BallisticTrauma.Scripts.Behaviours;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class MovingActor : Actor
    {
        [SerializeField]
        protected float _speed;

        [SerializeField]
        protected MovementBehaviour _movementBehaviour;
    }
}