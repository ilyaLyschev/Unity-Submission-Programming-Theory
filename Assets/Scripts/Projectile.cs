using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10.0f;
    public float ttlSec = 1.0f;

    private float ageSec = 0.0f;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Vector3.forward * speed * Time.deltaTime);

        ageSec += Time.deltaTime;
        if (ageSec > ttlSec)
            Destroy(gameObject);    
    }
}
