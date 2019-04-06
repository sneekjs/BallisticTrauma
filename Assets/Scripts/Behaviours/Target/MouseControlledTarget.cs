namespace JorritSlaats.BallisticTrauma.Scripts.Behaviours
{
    using System.Collections;
    using System.Collections.Generic;
    using JorritSlaats.BallisticTrauma.Scripts.Actors;
    using JorritSlaats.BallisticTrauma.Scripts.Singletons;
    using UnityEngine;

    public class MouseControlledTarget : TargetBehaviour
    {
        public override void Target(Actor actor)
        {
            throw new System.NotImplementedException();
        }

        public override void Target(Player player)
        {
            float x = Input.GetAxis("Mouse X");

            //player.gameObject.transform.Rotate(new Vector3(0, x * GameManager.Instance.Sensitivity, 0));
            //VRAAG HIER OM HULP MET HET AANROEPEN VAN SENSITIVITY!!

            float y = Input.GetAxis("Mouse Y");

            //player.Camera.transform.Rotate(new Vector3(0, y * GameManager.Instance.Sensitivity, 0));
            //VRAAG HIER OM HULP MET HET AANROEPEN VAN SENSITIVITY!!

            //En vraag hoe je fatsoenlijk overerft van een singleton zodat er maar 1 van iedere child class is
            //Nu je er toch bent, moet ik hier ook nog * Time.DeltaTime doen?
        }
    }
}