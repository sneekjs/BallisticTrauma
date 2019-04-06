namespace JorritSlaats.BallisticTrauma.Scripts.Singletons
{
    using JorritSlaats.BallisticTrauma.Scripts.Enums;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class GameManager : Singleton
    {
        private GameState _gameState;

        private int _currentDifficulty = 1;

        [SerializeField]
        private float _sensitivity = 60;        

        public float Sensitivity
        {
            get { return _sensitivity; }
            set { _sensitivity = value; }
        }
    }
}