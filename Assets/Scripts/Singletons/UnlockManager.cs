namespace JorritSlaats.BallisticTrauma.Scripts.Singletons
{
    using JorritSlaats.BallisticTrauma.Scripts.Weapons;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class UnlockManager : MonoBehaviour
    {
        //all unlocked and locked upgrades/perks/weapons and other pre-start selectables should be remembered here

        [SerializeField]
        private List<Weapon> _allWeapons = new List<Weapon>();

        private int _totalCurrenty;

        private int _currentRun;

        protected static UnlockManager instance = null;

        public static UnlockManager Instance
        {
            get { return instance; }
        }

        public List<Weapon> AllWeapons
        {
            get { return _allWeapons; }
            set { _allWeapons = value; }
        }

        void Awake()
        {
            if (instance != null && instance != this)
            {

                Destroy(this.gameObject);
                return;
            }
            else
            {
                instance = this;
            }
            DontDestroyOnLoad(this.gameObject);
        }
    }
}