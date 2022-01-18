using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] Material material;

    void Start()
    {
        Button button = this.gameObject.GetComponent<Button>();
        button.onClick.AddListener(onChangePrefab);
    }

    void onChangePrefab()
    {
        GameObject sessionOrigin = GameObject.FindWithTag("ARSessionOrigin");
        ARFaceManager arFaceManager = sessionOrigin.GetComponent<ARFaceManager>();

        foreach (ARFace face in arFaceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = material;
        }
    }
}
