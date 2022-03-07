using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
	private int count;
	public Text countText;
    public Text winText;
	public int numPickups;

	private bool isGrounded; 

	private Rigidbody rb;
    private PlayerBall playerBall;
	private PlayerCube playerCube;
	private string currentShapeOfPlayer="cube";

	void Start()
	{
		playerCube = gameObject.AddComponent<PlayerCube>();
		playerBall = gameObject.AddComponent<PlayerBall>();
		rb = GetComponent<Rigidbody>();
		count = 0;
		//SetCountText();
		//winText.text = "";
	}

	void FixedUpdate()
	{
        if(currentShapeOfPlayer=="ball")
		{
			playerBall.MoveBallPlayer(rb);
		}
		if (currentShapeOfPlayer == "cube")
		{
			if (playerCube._isCubeMoving) return;
			playerCube.MoveCubePlayer();
		}
	}
    private void Update()
	{
		
		Jump();//space button makes player jump
	}


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
	private void Jump()
	{
		if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
		{
			rb.AddForce(playerBall.Jump());//player.Jump() return's player's jump vector for ball
		}
	}
	
	void SetCountText()
	{
		countText.text = "Count: " + count.ToString();
		if (count >= numPickups)
		{
			winText.text = "You win!";
		}
	}
}
