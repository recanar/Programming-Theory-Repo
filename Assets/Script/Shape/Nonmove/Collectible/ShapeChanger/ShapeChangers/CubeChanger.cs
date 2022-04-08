using UnityEngine;

public class CubeChanger : ShapeChanger
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("PlayerCube"))
        {
            ResetMovementPlayer(other.gameObject);//if player shape changes reset current player velocity before change

            other.gameObject.SetActive(false);
            GameManager.Instance.PlayerShapeChange("PlayerCube");
        }
    }
}
