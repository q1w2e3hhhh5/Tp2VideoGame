using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamigaze : MonoBehaviour
{

    public GameObject explosion;
    public GameObject playerObj;
    private int kamigazeHp = 15;
    public float movementSpeed = 0f;



    void Start()
    {

    }

    void Update()
    {

        if (playerObj != null) {
            transform.position = Vector3.MoveTowards(transform.position, playerObj.transform.position, movementSpeed * Time.deltaTime);

            //Debug.Log("Player position is: " + playerObj.transform.position);
            //Debug.Log("Kamikaze position is: " + transform.position);
        }

        if (kamigazeHp <= 0) {
            Instantiate(explosion, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(gameObject); //kms
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
    }


}
