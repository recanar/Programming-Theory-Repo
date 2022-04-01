using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : Shape
{
    protected virtual void OnCollisionEnter(Collision collision)
    {
       if(collision.gameObject.CompareTag("PlayerBall") || collision.gameObject.CompareTag("PlayerCube"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
