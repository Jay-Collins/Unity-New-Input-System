using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCH1 : MonoBehaviour
{
    private void Start()
    {
        MainCH1.pressSpace += Teleport;
    }

    private void Teleport(Vector3 pos)
    {
        transform.position = pos;
    }

    private void OnDisable()
    {
        MainCH1.pressSpace -= Teleport;
    }
}
