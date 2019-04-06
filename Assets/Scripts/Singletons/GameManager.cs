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
    }
}