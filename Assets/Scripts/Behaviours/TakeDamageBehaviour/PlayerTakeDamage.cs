namespace JorritSlaats.BallisticTrauma.Scripts.Behaviours.TakeDamageBehaviours
{
    using JorritSlaats.BallisticTrauma.Scripts.Actors;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class PlayerTakeDamage : TakeDamageBehaviour
    {
        [Range(0, 100)]
        [SerializeField]
        private float _camShakeIntensity = 25;

        public override void TakeDamage(Actor actor, float damage)
        {
            base.TakeDamage(actor, damage);
            Player player = actor.gameObject.GetComponent<Player>();
            player.PlayerUI.UpdateHealthBar(player);

            CameraShake(player, damage);
        }

        private void CameraShake(Player player, float damage)
        {
            StartCoroutine(Shake(player.Camera.gameObject, .1f, damage));
        }

        private IEnumerator Shake(GameObject camera, float duration, float damage)
        {
            Vector3 originalPos = camera.transform.localPosition;

            float elapsed = 0.0f;
            
            while(elapsed < duration)
            {
                float x = Random.Range(-1f, 1f) * (damage / (100 - _camShakeIntensity));
                float y = Random.Range(-1f, 1f) * (damage / (100 - _camShakeIntensity));
                float z = Random.Range(-1f, 1f) * (damage / (100 - _camShakeIntensity));

                camera.transform.localPosition = new Vector3(x, y, z);

                elapsed += Time.deltaTime;

                yield return null;
            }

            camera.transform.localPosition = originalPos;
        }
    }
}