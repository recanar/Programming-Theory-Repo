using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeChanger : NonMove
{
    public override void GiveColor()
    {
        throw new System.NotImplementedException();
    }
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("PlayerCube") && gameObject.CompareTag("CubeChanger"))
        {
            ResetMovePlayer(other.gameObject);//if player shape changes reset current player velocity before change

            GameManager.Instance.playerPosition = transform.position;
            other.gameObject.SetActive(false);
            GameManager.Instance.PlayerShapeChange("PlayerCube");
        }
        else if (!other.gameObject.CompareTag("PlayerBall") && gameObject.CompareTag("BallChanger"))
        {
            ResetMovePlayer(other.gameObject);//if player shape changes reset current player velocity before change

            GameManager.Instance.playerPosition = transform.position;
            other.gameObject.SetActive(false);
            GameManager.Instance.PlayerShapeChange("PlayerBall");
        }
    }
    void ResetMovePlayer(GameObject player)
    {
        player.GetComponent<Rigidbody>().velocity = Vector3.zero;
        player.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }
}
