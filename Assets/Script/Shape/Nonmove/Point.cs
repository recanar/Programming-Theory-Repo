using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : NonMove
{
    public override void GiveColor()
    {
        throw new System.NotImplementedException();
    }
    void Update()
    {
        transform.Rotate(new Vector3(0, 45, 0) * Time.deltaTime);
    }
    protected virtual void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PlayerBall") || other.gameObject.CompareTag("PlayerCube"))
        {
            GameManager.Instance.IncreasePoint();
            Destroy(gameObject);
        }
    }
}
