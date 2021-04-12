using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.colourfulcoding.customVRLogic
{
    public class BallGrabbable : OVRGrabbable
    {

        private BallHandler ballHanlder;


        protected override void Start()
        {
            base.Start();
            ballHanlder = GetComponent<BallHandler>();

        }

        public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
        {
            base.GrabEnd(linearVelocity, angularVelocity);

        }
    }

}

