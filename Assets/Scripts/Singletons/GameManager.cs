namespace JorritSlaats.BallisticTrauma.Scripts.Singletons
{
    using JorritSlaats.BallisticTrauma.Scripts.Actors;
    using JorritSlaats.BallisticTrauma.Scripts.Enums;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class GameManager : MonoBehaviour
    {
        [SerializeField]
        private float _sensitivity = 100;       
        
        [SerializeField]
        private Player _player;

        protected static GameManager instance = null;

        private GameState _gameState;

        private int _currentDifficulty = 1;
                
        public static GameManager Instance
        {
            get { return instance; }
        }

        public float Sensitivity
        {
            get { return _sensitivity; }
            set { _sensitivity = value; }
        }

        public Player Player
        {
            get { return _player; }
            private set { _player = value; }
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