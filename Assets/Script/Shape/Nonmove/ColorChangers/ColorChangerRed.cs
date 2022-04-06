using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangerRed : ColorChanger
{
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Renderer>().material.color = Color.red;
    }
}
