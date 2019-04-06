namespace JorritSlaats.BallisticTrauma.Scripts.Behaviours
{
    using JorritSlaats.BallisticTrauma.Scripts.Actors;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public abstract class MovementBehaviour : MonoBehaviour
    {
        public abstract void Move(MovingActor movingActor);
    }
}