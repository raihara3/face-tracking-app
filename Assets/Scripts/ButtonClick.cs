using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ButtonClick : MonoBehaviour
{
    [SerializeField] Material material;

    public void ChangePrefab()
    {
        GameObject sessionOrigin = GameObject.FindWithTag("ARSessionOrigin");
        ARFaceManager arFaceManager = sessionOrigin.GetComponent<ARFaceManager>();
        //arFaceManager.facePrefab = face;
        //arFaceManager.facePrefab.GetComponent<MeshRenderer>().material = material;

        foreach(ARFace face in arFaceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = material;
        }
    }
}
