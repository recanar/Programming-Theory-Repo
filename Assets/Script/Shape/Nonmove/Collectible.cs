using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : NonMove
{
    public override void GiveColor()
    {
        throw new System.NotImplementedException();
    }
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}
