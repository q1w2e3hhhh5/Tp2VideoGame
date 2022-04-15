using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamigaze : MonoBehaviour
{

    private GameObject playerObj = null;
    public float movementSpead = 0f, rotationSpeed = 150f;



    void Start()
    {
        playerObj = GameObject.FindGameObjectWithTag("Player");

    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerObj.transform.position, movementSpead * Time.deltaTime);

        Debug.Log("Player position is: " + playerObj.transform.position);
        Debug.Log("Kamikaze position is: " + transform.position);
    }

    public void Explode()
    {
        Destroy(gameObject);//kill the asteroid
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.transform.name);
        if (other.CompareTag("Asteroid") || other.CompareTag("Player"))
        {
            Destroy(gameObject); //kms
            //todo how do i make it boom
          
            other.transform.GetComponent<Asteroid>()?.Explode();

            if (other.CompareTag("Player")) { 
                //game over
            }

        }
    }

}
