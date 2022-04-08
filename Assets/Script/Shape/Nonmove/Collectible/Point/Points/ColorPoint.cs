using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPoint : Point
{
    protected override void OnTriggerEnter(Collider other)
    {
        CollectPointIfHaveSameColor(other.gameObject);//if other gameobject have same color with this object destroy this and increase point
    }
    void CollectPointIfHaveSameColor(GameObject player)
    {
        if (player.gameObject.transform.parent.gameObject.CompareTag("Player")
            && player.gameObject.GetComponent<Renderer>().material.color == gameObject.GetComponent<Renderer>().material.color)
        {
            LevelManager.InstanceLevel.IncreasePoint();
            Destroy(gameObject);
        }
    }
}