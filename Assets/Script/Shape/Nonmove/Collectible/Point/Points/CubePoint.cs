using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePoint : Point
{
    protected override void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PlayerCube"))
        {
            LevelManager.InstanceLevel.IncreasePoint();
            Destroy(gameObject);
        }
    }
}
