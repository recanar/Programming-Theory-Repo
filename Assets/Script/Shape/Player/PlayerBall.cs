using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBall : Player
{
    public float speed=10;
    private void FixedUpdate()
    {
        MovePlayer();
    }
    public override void MovePlayer()
    {
        rb.AddForce(MoveBallPlayer() * speed);//player.MovePlayer() returns player's movement vector for ball
    }
    public Vector3 MoveBallPlayer()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        return movement;
    }
    public override void GiveColor()
    {
    }
}
