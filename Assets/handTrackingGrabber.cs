using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;

public class handTrackingGrabber : OVRGrabber
{

    private OVRHand oVRHand;
    private float pinchThreshold;

    protected override void Start()
    {
        base.Start();
        oVRHand = GetComponent<OVRHand>();

    }

    public override void Update()
    {
        base.Update();
        CheckIndexPinch();
    }

    void CheckIndexPinch()
    {
        float pinchStrength = oVRHand.GetFingerPinchStrength(OVRHand.HandFinger.Index);

        if(!m_grabbedObj && pinchStrength > pinchThreshold && m_grabCandidates.Count > 0)
        {
            GrabBegin();
        }
        else if(m_grabbedObj && !(pinchStrength > pinchThreshold))
        {
            GrabEnd();
        }
    }

}
