using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float duration = 0.75f;
    public float finalSize = 2f;

    private Vector3 initScale;
    private float timeElapsed = 0;

    // Start is called before the first frame update
    void Start()
    {
        initScale = transform.localScale; 
        Destroy(gameObject, duration);

    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        transform.localScale = initScale * (finalSize * timeElapsed / duration);
    }
}
