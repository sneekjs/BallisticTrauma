namespace JorritSlaats.BallisticTrauma.Scripts.Actors
{
    using JorritSlaats.BallisticTrauma.Scripts.Singletons;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Turret : StaticEnemy
    {
        [SerializeField]
        private GameObject _bulletPrefab;

        [SerializeField]
        private List<GameObject> _barrels = new List<GameObject>();

        [SerializeField]
        private float _fireRate;

        [SerializeField]
        private bool _firesIndividually;

        private int _individualFireBarrelIndex;

        private bool _canFire = true;

        private void Update()
        {
            Shoot();
        }

        protected virtual void Shoot()
        {
            if (_firesIndividually)
            {
                if (_canFire)
                {
                    SpawnBullet(_individualFireBarrelIndex);
                    StartCoroutine(WaitForNextBarrel());
                }
            }
            else
            {
                if (_canFire)
                {
                    for (int i = 0; i < _barrels.Count; i++)
                    {
                        SpawnBullet(i);
                    }
                    StartCoroutine(WaitForNextBullet());
                }
            }      
        }

        protected IEnumerator WaitForNextBullet()
        {
            _canFire = false;
            yield return new WaitForSeconds(60/_fireRate);
            _canFire = true;
        }

        protected IEnumerator WaitForNextBarrel()
        {
            _canFire = false;
            yield return new WaitForSeconds(60 / _fireRate);
            _individualFireBarrelIndex++;
            if (_individualFireBarrelIndex == _barrels.Count)
            {
                _individualFireBarrelIndex = 0;
            }
            _canFire = true;
        }

        private void SpawnBullet(int currentBarrel)
        {
            Instantiate(_bulletPrefab, _barrels[currentBarrel].transform.position, _barrels[currentBarrel].transform.rotation);
        }
    }
}