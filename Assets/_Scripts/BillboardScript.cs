using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fluent;

public class BillboardScript : MonoBehaviour
{

    public GameObject currentCamera;

    void Update()
    {
        currentCamera = FluentManager.Instance.activeCamera;
        transform.LookAt(transform.position + currentCamera.transform.rotation * -Vector3.back, currentCamera.transform.rotation * -Vector3.down);
    }
}
