using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    GameObject activePlayer;
    private void Update()
    {
        for (int i = 0; i < player.transform.childCount; i++)
        {
            if (player.transform.GetChild(i).gameObject.activeSelf)
            {
                activePlayer = player.transform.GetChild(i).gameObject;
                break;
            }
        }

        transform.position = activePlayer.transform.position + new Vector3(0, 10, -10);
    }
}
