namespace JorritSlaats.BallisticTrauma.Scripts.Actors
{
    using JorritSlaats.BallisticTrauma.Scripts.Singletons;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Turret : StaticEnemy
    {
        [SerializeField]
        private GameObject _bulletPrefab;

        [SerializeField]
        private List<GameObject> _barrels = new List<GameObject>();        
    }
}