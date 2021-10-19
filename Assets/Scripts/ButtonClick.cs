using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ButtonClick : MonoBehaviour
{
    [SerializeField] GameObject face;

    public void ChangePrefab()
    {
        GameObject sessionOrigin = GameObject.FindWithTag("ARSessionOrigin");
        ARFaceManager arFaceManager = sessionOrigin.GetComponent<ARFaceManager>();
        arFaceManager.facePrefab = face;
    }
}
