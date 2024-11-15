using UnityEngine;
using UnityEngine.XR;
#if UNITY_XRHANDSSUBSYSTEM
using UnityEngine.XR.Hands; // Ensure the correct namespace
#endif

public class HandTrackingController : MonoBehaviour
{
    public GameObject handModel;
#if UNITY_XRHANDSSUBSYSTEM
    private XRHandSubsystem handSubsystem;
#endif

    void Start()
    {
#if UNITY_XRHANDSSUBSYSTEM
        foreach (var subsystem in SubsystemManager.GetInstances<XRHandSubsystem>())
        {
            handSubsystem = subsystem;
            if (handSubsystem != null)
            {
                handSubsystem.Start();
                break;
            }
        }
#endif
    }

    void Update()
    {
#if UNITY_XRHANDSSUBSYSTEM
        if (handSubsystem == null) return;

        var leftHand = handSubsystem.leftHand;

        if (leftHand.isTracked)
        {
            handModel.transform.position = leftHand.position;
            handModel.transform.rotation = leftHand.rotation;
        }
#endif
    }
}

