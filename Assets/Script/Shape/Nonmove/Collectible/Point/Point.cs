using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : Collectible
{
    protected virtual void OnTriggerEnter(Collider other)
    {
        GetPointOnAnyPlayerEnter(other.gameObject);//add point when any gameobject which child of player enter the trigger
    }
    private void GetPointOnAnyPlayerEnter(GameObject player)
    {
        if (player.gameObject.transform.parent.gameObject.CompareTag("Player"))
        {
            LevelManager.InstanceLevel.IncreasePoint();
            Destroy(gameObject);
        }
    }
    
}
