using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBall : Player
{
    private readonly float jumpHeight=250;
    public override Vector3 MovePlayer()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        return movement;
    }
    public override Vector3 Jump()
    {
        Vector3 jump = new Vector3(0.0f, jumpHeight, 0.0f);
        return jump;
    }
    public override void GiveColor()
    {
        throw new System.NotImplementedException();
    }
}
