using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : NonMove
{
    void Update()
    {
        RotateAround();
    }
    protected virtual void RotateAround()
    {
        transform.Rotate(new Vector3(0, 45, 0) * Time.deltaTime);
    }
}
