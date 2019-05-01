namespace JorritSlaats.BallisticTrauma.Scripts.UI
{
    using JorritSlaats.BallisticTrauma.Scripts.Actors;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UI;

    public class PlayerUI : MonoBehaviour
    {
        [SerializeField]
        private Slider _healthBar;

        public void UpdateHealthBar(Player player)
        {
            float healthPercent = 100 / (player.MaxHealth / player.CurrentHealth);
            Debug.Log(healthPercent);
            _healthBar.value = healthPercent;
        }
    }
}