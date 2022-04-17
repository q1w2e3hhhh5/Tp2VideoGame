using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPMissile : MonoBehaviour
{


    public GameObject explosion;

    public GameObject player;
    public float movementSpeed = 2f;
    public GameObject asteriod;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(0, movementSpeed * Time.deltaTime, 0);



       // Debug.Log("Player health: " + playerPv);

    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }


    private void OnTriggerEnter(Collider other)
    {
        //make that the asteroid has hp?
    }

}
