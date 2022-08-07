using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Base class for all enemies.
/// </summary>
public class Enemy : MonoBehaviour
{
    protected float healthPoints = 10;
    protected float damagePoints = 1;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        Debug.Log("Enemy.Start() called");
    }
}
