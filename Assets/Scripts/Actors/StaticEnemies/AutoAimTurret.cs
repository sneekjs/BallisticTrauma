namespace JorritSlaats.BallisticTrauma.Scripts.Actors
{
    using JorritSlaats.BallisticTrauma.Scripts.Behaviours;
    using JorritSlaats.BallisticTrauma.Scripts.Singletons;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class AutoAimTurret : Turret
    {
        [SerializeField]
        private GameObject _moveableTurretHead;

        [SerializeField]
        private float _turningSpeed;
        
        private bool _seesTarget = false;

        private GameObject _target;

        protected override void Start()
        {
            base.Start();
            _target = GameManager.Instance.Player.Camera.gameObject;
        }

        private void Update()
        {
            LookForTarget();

            if (_seesTarget)
            {
                AimAtTarget(_target.transform.position);
                Shoot();
            }
            else
            {
                AimAtTarget(_moveableTurretHead.transform.position + Vector3.forward);
            }
        }

        private void LookForTarget()
        {
            RaycastHit hit;
            var dir = _target.transform.position - _moveableTurretHead.transform.position;
            Ray myRay = new Ray(_moveableTurretHead.transform.position, dir);

            Debug.DrawRay(_moveableTurretHead.transform.position, dir);

            if (Physics.Raycast(myRay, out hit))
            {
                _seesTarget = hit.collider.CompareTag("Player");
            }
        }

        private void AimAtTarget(Vector3 target)
        {
            Quaternion targetQuaternion = Quaternion.LookRotation(target - _moveableTurretHead.transform.position);
            _moveableTurretHead.transform.rotation = Quaternion.RotateTowards(_moveableTurretHead.transform.rotation, targetQuaternion, _turningSpeed * Time.deltaTime);
        }

        protected override void Shoot()
        {
            base.Shoot();
        }
    }
}