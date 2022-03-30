using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : NonMove
{
    void Update()
    {
        transform.Rotate(new Vector3(0, 45, 0) * Time.deltaTime);
    }
    protected virtual void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PlayerBall") || other.gameObject.CompareTag("PlayerCube"))
        {
            LevelManager.InstanceLevel.IncreasePoint();
            Destroy(gameObject);
        }
    }
}
