using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamigaze : MonoBehaviour
{

    private GameObject playerObj = null;
    public float movementSpead = 0f, rotationSpeed = 150f;
    public GameObject explosiont;

    

    // Start is called before the first frame update
    void Start()
    {
        playerObj = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += playerObj.transform.position * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, playerObj.transform.position, movementSpead * Time.deltaTime);
        Debug.Log("Player position is: " + playerObj.transform.position);
        Debug.Log("Kamikaze position is: " + transform.position);
    }
}
