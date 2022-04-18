using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPMissile : MonoBehaviour
{
    public float movementSpeed = 3f;

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


}
