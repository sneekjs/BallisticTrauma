namespace JorritSlaats.BallisticTrauma.Scripts.Weapons
{
    using JorritSlaats.BallisticTrauma.Scripts.Enums;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Weapon : MonoBehaviour
    {
        private WeaponType _weaponType;

        private GameObject _bullet;

        private float _rateOfFire;

        public void Fire()
        {
            //maak via inheritance een weapon class aan voor ieder weapon type en rethink of weapon type miss weg kan
        }
    }
}