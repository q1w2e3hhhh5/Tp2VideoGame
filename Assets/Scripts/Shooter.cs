using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject SPMissile, rightCanon, leftCanon;

    public float nextActionTime = 4.0f;
    public float period = 2.0f;
    private GameObject player = null;
    public float speed = 1.0f;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        //does not work is now on a fixed posisition
        //rotate to player direction
        //https://docs.unity3d.com/ScriptReference/Vector3.RotateTowards.html

        if (player != null) { 
         //   Vector3 playerDirection = player.transform.position - transform.position;
         //  float signleStep = speed * Time.deltaTime;
         //  Vector3 newDirection = Vector3.RotateTowards(transform.position, playerDirection, signleStep, 0.0f);
         // transform.rotation = Quaternion.LookRotation(newDirection);
        }


        if (Time.time > nextActionTime) { 
            nextActionTime = Time.time + period;
            Instantiate(SPMissile, rightCanon.transform.position, rightCanon.transform.rotation);
            Instantiate(SPMissile, leftCanon.transform.position, leftCanon.transform.rotation);
        }


    }
}
