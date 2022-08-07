using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCapsule : Enemy // INHERITANCE
{
    // Start is called before the first frame update
    protected override void Start()
    {        
        base.Start();
        Debug.Log("EnemyCapsule.Start() called");
    }
}
