using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{

    private GameObject player = null;
    private Vector3 originalPos;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        originalPos = transform.position;

    }

    // Update is called once per frame
    void Update()
    {

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
