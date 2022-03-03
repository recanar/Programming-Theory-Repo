using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

	public float speed;
	public float jumpHeight;
    public Text countText;
    public Text winText;
    private bool isGrounded; 
	public int numPickups;

	private Rigidbody rb;
	private int count;
	PlayerBall player = new PlayerBall();

	void Start()
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
		//SetCountText();
		//winText.text = "";
	}

	void FixedUpdate()
	{
		MoveBallPlayer();
	}
    private void Update()
    {
		Jump();//space button make player jump
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
		if (Input.GetKeyDown("space") && isGrounded)
		{
			Vector3 jump = new Vector3(0.0f, jumpHeight, 0.0f);
			rb.AddForce(jump);
		}
	}

	private void MoveBallPlayer()
	{
		rb.AddForce(player.MovePlayer() * speed);//player.MovePlayer() returns player's movement vector for ball
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
