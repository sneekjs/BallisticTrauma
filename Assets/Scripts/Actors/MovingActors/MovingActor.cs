namespace JorritSlaats.BallisticTrauma.Scripts.Actors
{
    using JorritSlaats.BallisticTrauma.Scripts.Behaviours;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class MovingActor : Actor
    {
        [SerializeField]
        private float speed;

        [SerializeField]
        protected MovementBehaviour _movementBehaviour;

        public float Speed
        {
            get { return speed; }
            set { speed = value; }
        }
    }
}