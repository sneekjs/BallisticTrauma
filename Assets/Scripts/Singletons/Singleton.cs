namespace JorritSlaats.BallisticTrauma.Scripts.Singletons
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public abstract class Singleton : MonoBehaviour
    {
        protected static Singleton instance = null;

        public static Singleton Instance
        {
            get { return instance; }
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