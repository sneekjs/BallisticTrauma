namespace JorritSlaats.BallisticTrauma.Scripts.Behaviours
{
    using System.Collections;
    using System.Collections.Generic;
    using JorritSlaats.BallisticTrauma.Scripts.Actors;
    using JorritSlaats.BallisticTrauma.Scripts.Singletons;
    using UnityEngine;

    public class MouseControlledTarget : TargetBehaviour
    {
        [SerializeField]
        private float _viewRangeY = 80;

        private float _rotY = 0;

        public override void Target(Actor actor)
        {
            throw new System.NotImplementedException();
        }

        public override void Target(Player player)
        {
            float sensitivity = GameManager.Instance.Sensitivity;

            player.Camera.transform.Rotate(Vector3.left * Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime);
            float _rotX = Input.GetAxis("Mouse X") * sensitivity;
            _rotY += Input.GetAxis("Mouse Y") * sensitivity / 35;
            _rotY = Mathf.Clamp(_rotY, -_viewRangeY, _viewRangeY);

            player.Camera.transform.localRotation = Quaternion.Euler(-_rotY, 0f, 0f);
            player.transform.Rotate(Vector3.up * _rotX * Time.deltaTime);
        }
    }
}