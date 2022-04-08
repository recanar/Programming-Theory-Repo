using UnityEngine;

public class BallChanger : ShapeChanger
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("PlayerBall"))
        {
            ResetMovementPlayer(other.gameObject);//if player shape changes reset current player velocity before change

            other.gameObject.SetActive(false);
            GameManager.Instance.PlayerShapeChange("PlayerBall");
        }
    }
}
