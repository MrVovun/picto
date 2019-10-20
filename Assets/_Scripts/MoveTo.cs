using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fluent;

public class MoveTo : MonoBehaviour
{
    private GameObject character;
    public GameObject target;
    public GameObject entrance;
    public GameObject myPosition;
    public GameObject cameraON;
    public GameObject cameraOFF;
    void Start()
    {
        character = GetComponent<GameObject>();
    }

    void Update()
    {
        if (target != null)
        {
            float step = GetComponent<StatsHolder>().speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, step);
            if (tag == "Player")
            {
                if (transform.position == myPosition.transform.position)
                {
                    target = null;
                }
            }
            else
            {
                if (transform.position == entrance.transform.position)
                {
                    target = myPosition;
                }
                else if (transform.position == myPosition.transform.position && name == "Queen" && myPosition.name == "PointMoveTo5")
                {
                    target = null;
                    cameraON.SetActive(true);
                    cameraOFF.SetActive(false);
                    FluentManager.Instance.activeCamera = cameraON;
                    GetComponentInChildren<Actor1Intro>().StartConversation();
                } else if (transform.position == myPosition.transform.position)
                {
                    target = null;
                }
            }
        }
    }
}
