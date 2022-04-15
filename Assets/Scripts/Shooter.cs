using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public float movementSpeed = 5f, rotationSpeed = 150f;

    public GameObject SPMissile, rightCanon,leftCanon;

    private float nextActionTime = 0.0f;
    public float period = 0.1f;


    // Start is called before the first frame update
    void Start()
    {
        //rotate to specific direction


        
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time > nextActionTime) { 
            nextActionTime = Time.time + period;
            Instantiate(SPMissile, rightCanon.transform.position, rightCanon.transform.rotation);
            Instantiate(SPMissile, leftCanon.transform.position, leftCanon.transform.rotation);
        }


    }
}
