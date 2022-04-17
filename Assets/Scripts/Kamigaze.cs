using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamigaze : MonoBehaviour
{

    public GameObject explosion;
    public GameObject player;

    private int kamigazeHp = 15;
    public float movementSpeed = 1f;



    void Start()
    {
      
    }

    void Update()
    {
        //makes no sense why does this not work
        if (player != null) {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, movementSpeed * Time.deltaTime);
            Debug.Log("Player position is: " + player.transform.position);
            Debug.Log("Kamikaze position is: " + transform.position);
        }



    }

    public void Explode()
    {
        Destroy(gameObject);//kill the asteroid
    }


    private void OnTriggerEnter(Collider other)
    {
        kamigazeHp--;
        Debug.Log("Kamikaze got hit");
        Debug.Log("Kamigaze : "+ kamigazeHp);

        if (kamigazeHp <= 0)
        {
            Instantiate(explosion, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(gameObject); //kms
        }

    }


}
