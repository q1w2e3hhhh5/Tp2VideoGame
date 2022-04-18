using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float movementSpeed = 5f, rotationSpeed = 150f;

    public GameObject missile, canon;
    public GameObject explosion;
    public GameObject healthHp;
    private int playerHp = 5;

    public float nextActionTime = 0.5f;
    public float period = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        SpawnHleathHp();
    }

    // Update is called once per frame
    void Update()
    {
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        transform.Rotate(0, 0, -rotation * Time.deltaTime);

        float translation = Input.GetAxis("Vertical") * movementSpeed;
        transform.Translate(0, translation * Time.deltaTime, 0, Space.Self);

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
        Debug.Log("Player HP: " + playerHp);

    }

    public void Explode()
    {
        Destroy(gameObject);
    }


    public void SpawnHleathHp() {
        //https://www.youtube.com/watch?v=IXDvl8aTM_M
        bool healthSpawned = false;
        while (!healthSpawned) {
            Vector3 healthHpPos = new Vector3(Random.Range(-7f, 7f), Random.Range(-4f, 4f), 0f);
            if ((healthHpPos - transform.position).magnitude < 3)
            {
                continue;
            }
            else {
                Instantiate(healthHp, healthHpPos, Quaternion.identity);
                healthSpawned = true;
            }

        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Health"))
        {
            playerHp = playerHp + 2;
            Destroy(other.gameObject);
            SpawnHleathHp();
        }
        else if (other.CompareTag("Missile")){
        
        
        }
        else {
            Debug.Log("Hit ");
            playerHp--;

        }

    }
}
