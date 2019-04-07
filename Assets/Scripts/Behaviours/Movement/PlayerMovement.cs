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
            
            Vector3 pos = movingActor.transform.position + transform.right * y * (movingActor.Speed * Time.deltaTime);
            pos = pos + transform.forward * x * (movingActor.Speed * Time.deltaTime);
            movingActor.Rigidbody.MovePosition(pos);
        }
    }
}