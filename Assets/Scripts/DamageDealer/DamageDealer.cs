namespace JorritSlaats.BallisticTrauma.Scripts.DamageDealer
{
    using JorritSlaats.BallisticTrauma.Scripts.Behaviours;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class DamageDealer : MonoBehaviour
    {
        [SerializeField]
        private bool _canHitPlayer;
        
        [SerializeField]
        private float _damage;
    }
}