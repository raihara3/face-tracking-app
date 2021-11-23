using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class SwitchCamera : MonoBehaviour
{
    [SerializeField] ARCameraManager aRCameraManager;

    string direction = "user";

    public void Change()
    {
        if(direction == "user")
        {
            aRCameraManager.requestedFacingDirection = CameraFacingDirection.World;
            direction = "world";
        }
        else
        {
            aRCameraManager.requestedFacingDirection = CameraFacingDirection.User;
            direction = "user";
        }
    }
}
