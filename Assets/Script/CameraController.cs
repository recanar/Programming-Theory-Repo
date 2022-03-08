using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]GameObject player;
    private void FixedUpdate()
    {
        transform.position = player.transform.position+new Vector3(0,10,-10);
    }
}
