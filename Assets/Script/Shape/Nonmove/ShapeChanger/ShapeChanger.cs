using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeChanger : NonMove
{
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("PlayerCube") && gameObject.CompareTag("CubeChanger"))
        {
            ResetMovementPlayer(other.gameObject);//if player shape changes reset current player velocity before change

            other.gameObject.SetActive(false);
            GameManager.Instance.PlayerShapeChange("PlayerCube");
        }
        else if (!other.gameObject.CompareTag("PlayerBall") && gameObject.CompareTag("BallChanger"))
        {
            ResetMovementPlayer(other.gameObject);//if player shape changes reset current player velocity before change

            other.gameObject.SetActive(false);
            GameManager.Instance.PlayerShapeChange("PlayerBall");
        }
    }
    void ResetMovementPlayer(GameObject player)
    {
        player.GetComponent<Rigidbody>().velocity = Vector3.zero;
        player.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        GameManager.Instance.playerPosition = transform.position;//player start from taken object's position with removed physic forces
    }
}
