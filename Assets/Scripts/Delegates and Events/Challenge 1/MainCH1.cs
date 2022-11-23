using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class MainCH1 : MonoBehaviour
{
    // public delegate void ActionPressSpace(Vector3 pos);
    // public static event ActionPressSpace pressSpace;
    
    // below is the same thing written as an action
    // an action combines the above code into a single line
    // an action accomplishes the same as above

    public static Action<Vector3> pressSpace;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (pressSpace == null) return;
            
            var pos = new Vector3(5, 2, 0);
            pressSpace(pos);
        }
    }
}
