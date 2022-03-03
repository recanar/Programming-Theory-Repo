using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

	public float speed;
	[SerializeField] private float _cubeRollSpeed = 18;
	private bool _isCubeMoving;

	public Text countText;
    public Text winText;
	public int numPickups;

	private bool isGrounded; 

	private Rigidbody rb;
	private int count;
    private readonly PlayerBall player = new PlayerBall();

	void Start()
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
		//SetCountText();
		//winText.text = "";
	}

	void FixedUpdate()
	{
		//MoveBallPlayer();
	}
    private void Update()
	{
		if (_isCubeMoving) return;
		MoveCubePlayer();
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
			rb.AddForce(player.Jump());//player.Jump() return's player's jump vector for ball
		}
	}
	private void MoveCubePlayer()
	{
		if (Input.GetKeyDown(KeyCode.A)) Assemble(Vector3.left);
		else if (Input.GetKeyDown(KeyCode.D)) Assemble(Vector3.right);
		else if (Input.GetKeyDown(KeyCode.W)) Assemble(Vector3.forward);
		else if (Input.GetKeyDown(KeyCode.S)) Assemble(Vector3.back);
	}
	private void Assemble(Vector3 dir)
    {
		var anchor = transform.position +(Vector3.down+dir)*0.5f;
		var axis = Vector3.Cross(Vector3.up, dir);
		StartCoroutine(RollCube(anchor, axis));
	}
	IEnumerator RollCube(Vector3 anchor, Vector3 axis)
    {
		_isCubeMoving = true;
        for (int i = 0; i < (90/_cubeRollSpeed); i++)
        {
			transform.RotateAround(anchor, axis, _cubeRollSpeed);
			yield return new WaitForSeconds(0.005f);
		}
		_isCubeMoving = false;
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
