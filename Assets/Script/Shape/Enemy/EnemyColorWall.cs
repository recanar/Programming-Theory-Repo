using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyColorWall : Enemy
{
    protected override void OnCollisionEnter(Collision collision)
    {
        DestroyPlayerIfDontHaveSameColor(collision.gameObject);
    }

    void DestroyPlayerIfDontHaveSameColor(GameObject player)
    {
        if (player.transform.parent.gameObject.CompareTag("Player")
                    && player.GetComponent<Renderer>().material.color == gameObject.GetComponent<Renderer>().material.color)
        {
            Destroy(gameObject);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
