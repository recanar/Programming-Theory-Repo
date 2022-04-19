using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Player : Shape
{
    protected bool isGrounded;
    protected Rigidbody rb;

    [SerializeField]float speed = 10;
    [SerializeField]protected float jumpHeight = 250;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        Jump();//space button makes player jump
    }

    public virtual void MovePlayer()
    {
        rb.AddForce(MovePlayerVector() * speed);
    }
    protected virtual void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(JumpVector());//player.Jump() return's player's jump vector
        }
    }
    protected virtual Vector3 JumpVector()
    {
        Vector3 jump = new Vector3(0.0f, jumpHeight, 0.0f);
        return jump;
    }
    protected virtual Vector3 MovePlayerVector()
    {
        float moveHorizontal,moveVertical;
#if UNITY_ANDROID
            moveHorizontal = LevelManager.InstanceLevel.joystick.Horizontal;
            moveVertical = LevelManager.InstanceLevel.joystick.Vertical;
#elif UNITY_EDITOR_WIN
            moveHorizontal = Input.GetAxis("Horizontal");
            moveVertical = Input.GetAxis("Vertical");
#endif

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        return movement;
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
}
