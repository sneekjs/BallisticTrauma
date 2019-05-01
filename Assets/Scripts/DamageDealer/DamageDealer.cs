namespace JorritSlaats.BallisticTrauma.Scripts.DamageDealer
{
    using JorritSlaats.BallisticTrauma.Scripts.Behaviours;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class DamageDealer : MonoBehaviour
    {
        [SerializeField]
        protected bool _canHitPlayer;
        
        [SerializeField]
        protected float _damage;
    }
}