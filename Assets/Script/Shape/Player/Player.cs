using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Player : Shape
{
    private bool isGrounded;
    private readonly float jumpHeight = 250;
    public override abstract void GiveColor();
    protected Rigidbody rb;
    public GameObject playerBall;
    public GameObject playerCube;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        Jump();//space button makes player jump
    }

    public abstract void MovePlayer();
    protected virtual void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(JumpVector());//player.Jump() return's player's jump vector for ball
        }
    }
    public Vector3 JumpVector()
    {
        Vector3 jump = new Vector3(0.0f, jumpHeight, 0.0f);
        return jump;
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
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectible"))
        {
            playerBall.SetActive(false);
            playerCube.SetActive(true);
            Destroy(other.gameObject);
        }
    }
}
