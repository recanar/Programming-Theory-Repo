using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBall : Player
{
    public override Vector3 MovePlayer()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        return movement;
    }

}
