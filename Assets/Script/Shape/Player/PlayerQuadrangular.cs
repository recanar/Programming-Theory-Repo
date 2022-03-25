using UnityEngine;
using System.Collections;

public class PlayerQuadrangular : Player
{
	[SerializeField] float speed=10;

    void FixedUpdate()
	{
		MovePlayer();
	}


	public override void MovePlayer()
	{
		rb.AddForce(MovePlayerVector() * speed);//player.MovePlayer() returns player's movement vector for ball
	}
	public Vector3 MovePlayerVector()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

		return movement;
	}
}