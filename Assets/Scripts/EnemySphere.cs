using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySphere : Enemy // INHERITANCE
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();   
        Debug.Log("EnemySphere.Start() called");
    }
}
