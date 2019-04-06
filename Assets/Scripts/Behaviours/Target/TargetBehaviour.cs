namespace JorritSlaats.BallisticTrauma.Scripts.Behaviours
{
    using JorritSlaats.BallisticTrauma.Scripts.Actors;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public abstract class TargetBehaviour : MonoBehaviour
    {
        public abstract void Target(Actor actor);

        public abstract void Target(Player player);
    }
}