using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPMissile : MonoBehaviour
{


    public GameObject explosion;
    private int playerPv = 3;
    private int asteroidPv = 3;

    public GameObject player;
    public GameObject asteriod;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (playerPv <= 0) {
            Instantiate(explosion, player.transform.position, player.transform.rotation);
            player.transform.GetComponent<Player>()?.Explode();
        }

        if (asteroidPv <= 0)
        {
            Instantiate(explosion, asteriod.transform.position, asteriod.transform.rotation);
            asteriod.transform.GetComponent<Asteroid>()?.Explode();
        }

       // Debug.Log("Player health: " + playerPv);

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("HIT OR MISS I GUESS THEY NEVER MISS HUH");

        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            playerPv--;
        }
        if (other.CompareTag("Asteroid"))
        {
            Destroy(gameObject);
            asteroidPv--;
        }



    }

}
