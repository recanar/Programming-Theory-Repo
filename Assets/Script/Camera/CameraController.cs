using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    GameObject activePlayer;
    private void Update()
    {
        int i = 0;
        while (true)
        {
            if (player.transform.GetChild(i).gameObject.activeSelf)
            {
                activePlayer = player.transform.GetChild(i).gameObject;
                break;
            }
            i++;
        }

        transform.position = activePlayer.transform.position + new Vector3(0, 10, -10);
    }
}
