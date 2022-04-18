using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float movementSpeed = 5f;

    public GameObject explosion;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(0, movementSpeed * Time.deltaTime, 0);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Asteroid") || other.CompareTag("Destructible"))
        {
            Destroy(gameObject);
            
            if (other.CompareTag("Asteroid")) {
                other.transform.GetComponent<Asteroid>()?.Explode();
            }

        }
    }
}
