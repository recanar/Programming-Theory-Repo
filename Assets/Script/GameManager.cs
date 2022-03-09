using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int count;
    public Text countText;
    public Text winText;
    public int numPickups;
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= numPickups)
        {
            winText.text = "You win!";
        }
    }
}
