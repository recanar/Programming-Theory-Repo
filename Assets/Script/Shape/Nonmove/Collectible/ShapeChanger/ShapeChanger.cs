using UnityEngine;

public class ShapeChanger : Collectible
{
    protected void ResetMovementPlayer(GameObject player)//makes movement and physics zero for player on shape change
    {
        player.GetComponent<Rigidbody>().velocity = Vector3.zero;
        player.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        GameManager.Instance.playerPosition = transform.position;//player start from taken object's position with removed physic forces
    }
}
