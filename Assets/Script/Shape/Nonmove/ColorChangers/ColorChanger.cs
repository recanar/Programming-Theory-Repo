using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : NonMove
{
    void Update()
    {
        Rotate();
    }
    private void Rotate()
    {
        transform.Rotate(new Vector3(0, 45, 0) * Time.deltaTime);
    }
}
