using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPMissile : MonoBehaviour
{
    public float movementSpeed = 3f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, movementSpeed * Time.deltaTime, 0);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }


}
