using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
   // public float movementSpeed = 5f, speed = 1.0f;

    public GameObject SPMissile, rightCanon, leftCanon;

    public float nextActionTime = 4.0f;
    public float period = 2.0f;


    //public Transform player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //TO REWORK
        //rotate to specific direction
        //Vector3 playerDirection = player.position - transform.position;
        //float signleStep = speed * Time.deltaTime;
        //Vector3 newDirection = Vector3.RotateTowards(transform.position, playerDirection, signleStep, 0.0f);
        //.rotation = Quaternion.LookRotation(newDirection);


        if (Time.time > nextActionTime) { 
            nextActionTime = Time.time + period;
            Instantiate(SPMissile, rightCanon.transform.position, rightCanon.transform.rotation);
            Instantiate(SPMissile, leftCanon.transform.position, leftCanon.transform.rotation);
        }


    }
}
