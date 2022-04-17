using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float movementSpeed = 5f, rotationSpeed = 150f;

    public GameObject missile, canon;
    public GameObject explosion;
    private int playerHp = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        transform.Rotate(0, 0, -rotation * Time.deltaTime);

        float translation = Input.GetAxis("Vertical") * movementSpeed;
        transform.Translate(0, translation*Time.deltaTime, 0, Space.Self);

        var newPos = transform.position;
        newPos.x = Mathf.Clamp(newPos.x, -9, 9);
        newPos.y = Mathf.Clamp(newPos.y, -5, 5);
        transform.position = newPos;

        if (Input.GetKeyDown("space"))
        {
            Instantiate(missile, canon.transform.position, canon.transform.rotation);
        }

        if (playerHp <= 0)
        {
            Instantiate(explosion, gameObject.transform.position, gameObject.transform.rotation);
            gameObject.transform.GetComponent<Player>()?.Explode();
        }

    }

    public void Explode()
    {
        Destroy(gameObject);
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit ");
        playerHp--;
        Debug.Log("Player HP: " + playerHp);
        //my own missiles hurt me though
    }
}
