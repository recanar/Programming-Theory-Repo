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

	public GameObject cube;
	public GameObject ball;

	private bool isGrounded; 

	private Rigidbody rb;
    private PlayerBall playerBall;
	private PlayerCube playerCube;
	public bool isCube;

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
		if (gameObject.CompareTag("Ball"))
		{
			playerBall.MoveBallPlayer(rb);
		}
		else if (gameObject.CompareTag("Cube"))
		{
			Debug.Log("cube");
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
    private void OnTriggerEnter(Collider other)
    {
		if (other.gameObject.CompareTag("Collectible"))
		{
			ball.SetActive(false);
			cube.SetActive(true);
			Destroy(other.gameObject);
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
