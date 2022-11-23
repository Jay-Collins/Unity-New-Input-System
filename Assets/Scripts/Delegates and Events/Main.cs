using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // public delegate void ActionClick();
    // public static event ActionClick OnClick;
    
    // below is the same thing written as an action
    // an action combines the above code into a single line
    // an action accomplishes the same as above
    
    public static Action OnClick;
    
    public void ButtonClick()
    {
        if (OnClick == null) return;
        OnClick();
    }
}
