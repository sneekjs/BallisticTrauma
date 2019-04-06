namespace JorritSlaats.BallisticTrauma.Scripts.Behaviours
{
    using System.Collections;
    using System.Collections.Generic;
    using JorritSlaats.BallisticTrauma.Scripts.Actors;
    using UnityEngine;

    public class PlayerMovement : MovementBehaviour
    {
        public override void Move(MovingActor movingActor)
        {
            float x = Input.GetAxis("Vertical");
            float y = Input.GetAxis("Horizontal");
            Vector3 dir = new Vector3(x, 0, y);

            movingActor.Rigidbody.MovePosition(transform.position + dir * movingActor.Speed * Time.deltaTime);
        }
    }
}