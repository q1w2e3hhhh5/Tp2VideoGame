using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamigaze : MonoBehaviour
{

    public GameObject explosion;
    private GameObject player = null;

    private int kamigazeHp = 15;
    public float movementSpeed = 1f;



    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player"); //if i use the public method and assign it via the inspector it doesnt work
    }

    void Update()
    {
        //makes no sense why does this not work
        if (player != null) {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, movementSpeed * Time.deltaTime);
            Debug.Log("Player position is: " + player.transform.position);
            //Debug.Log("Kamikaze position is: " + transform.position);
        }
    }

    public void Explode()
    {
        Destroy(gameObject);
    }


    private void OnTriggerEnter(Collider other)
    {
        kamigazeHp--;
        Debug.Log("Kamikaze got hit");
        Debug.Log("Kamigaze : "+ kamigazeHp);

        if (kamigazeHp <= 0)
        {
            Instantiate(explosion, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(gameObject);
        }

    }


}
