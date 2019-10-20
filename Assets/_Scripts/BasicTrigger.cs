using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fluent;

public class BasicTrigger : MonoBehaviour
{
    public GameObject cameraON;
    public GameObject cameraOFF;
    public GameObject gameManager;

    private void OnTriggerEnter(Collider other)
    {
 //       if (other.gameObject.name == "Queen")
   //     {

            Destroy(this);
     //   }
    }
}
