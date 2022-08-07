using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        var otherObj = other.gameObject.GetComponent<Enemy>();

        if (otherObj != null)
            Destroy(gameObject);
    }
}
