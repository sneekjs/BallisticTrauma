namespace JorritSlaats.BallisticTrauma.Scripts.DamageDealer
{
    using JorritSlaats.BallisticTrauma.Scripts.Behaviours;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Bullet : MonoBehaviour
    {
        [SerializeField]
        private float _speed;

        [SerializeField]
        private DespawnBehaviour _despawnBehaviour;
    }
}