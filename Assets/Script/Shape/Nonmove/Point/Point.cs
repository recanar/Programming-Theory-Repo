using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : NonMove
{
    void Update()
    {
        Rotate();
    }
    protected virtual void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PlayerBall") || other.gameObject.CompareTag("PlayerCube"))
        {
            LevelManager.InstanceLevel.IncreasePoint();
            Destroy(gameObject);
        }
    }
    private void Rotate()
    {
        transform.Rotate(new Vector3(0, 45, 0) * Time.deltaTime);
    }

}
