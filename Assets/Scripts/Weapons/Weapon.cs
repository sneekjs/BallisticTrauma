namespace JorritSlaats.BallisticTrauma.Scripts.Weapons
{
    using JorritSlaats.BallisticTrauma.Scripts.Actors;
    using JorritSlaats.BallisticTrauma.Scripts.Enums;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Weapon : MonoBehaviour
    {
        [SerializeField]
        private string _gunName;

        [SerializeField]
        private GameObject _visuals;

        [SerializeField]
        private Transform _weaponTransform;

        [SerializeField]
        private List<Vector3> _barrelPositions = new List<Vector3>();

        [SerializeField]
        private bool _firesIndividually;

        [SerializeField]
        private WeaponType _weaponType;

        [SerializeField]
        private GameObject _bullet;

        [SerializeField]
        private float _fireRate;

        private bool _canFire = true;

        private int _individualFireBarrelIndex;

        public GameObject Visuals
        {
            get { return _visuals; }
            private set { _visuals = value; }
        }

        public void Fire(Player player)
        {
            if (_firesIndividually)
            {
                if (_canFire)
                {
                    SpawnBullet(_individualFireBarrelIndex, player);
                    StartCoroutine(WaitForNextBarrel());
                }
            }
            else
            {
                if (_canFire)
                {
                    for (int i = 0; i < _barrelPositions.Count; i++)
                    {
                        SpawnBullet(i, player);
                    }
                    StartCoroutine(WaitForNextBullet());
                }
            }
        }

        protected IEnumerator WaitForNextBullet()
        {
            _canFire = false;
            yield return new WaitForSeconds(60 / _fireRate);
            _canFire = true;
        }

        protected IEnumerator WaitForNextBarrel()
        {
            _canFire = false;
            yield return new WaitForSeconds(60 / _fireRate);
            _individualFireBarrelIndex++;
            if (_individualFireBarrelIndex == _barrelPositions.Count)
            {
                _individualFireBarrelIndex = 0;
            }
            _canFire = true;
        }

        private void SpawnBullet(int currentBarrel, Player player)
        {
            Instantiate(_bullet, player.Camera.gameObject.transform.position + _barrelPositions[currentBarrel], player.Camera.gameObject.transform.rotation);
        }
    }
}