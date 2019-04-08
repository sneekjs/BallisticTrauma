namespace JorritSlaats.BallisticTrauma.Scripts.DamageDealer
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class ForwardBullet : Bullet
    {
        private void Update()
        {
            Vector3 pos = transform.position + transform.forward * (Speed * Time.deltaTime);
            pos = pos + transform.forward * (Speed * Time.deltaTime);
            Rigidbody.MovePosition(pos);
        }
    }
}