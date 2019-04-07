namespace JorritSlaats.BallisticTrauma.Scripts.Singletons
{
    using JorritSlaats.BallisticTrauma.Scripts.Enums;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class GameManager : MonoBehaviour
    {
        private GameState _gameState;

        private int _currentDifficulty = 1;

        [SerializeField]
        private float _sensitivity = 100;        

        protected static GameManager instance = null;

        public static GameManager Instance
        {
            get { return instance; }
        }

        public float Sensitivity
        {
            get { return _sensitivity; }
            set { _sensitivity = value; }
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