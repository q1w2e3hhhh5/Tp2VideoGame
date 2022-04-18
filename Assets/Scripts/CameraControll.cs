using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{

    private GameObject player = null;
    private Vector3 originalPos;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        originalPos = transform.position;

    }

    void Update()
    {
        //not sure if thats whats wanted
        //doesnt even work properly anyways
        if (player != null) { 
            if (Input.GetAxis("Mouse ScrollWheel") > 0) {

                GetComponent<Transform>().position = player.transform.position;

            }
            if (Input.GetAxis("Mouse ScrollWheel") < 0)
            {
                GetComponent<Transform>().position = originalPos;
            }
        }




        
    }
}
