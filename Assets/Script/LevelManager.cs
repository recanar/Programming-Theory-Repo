using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] GameObject[] levels;
    int currentLevel=1;

    public int numPickups = 6;
    [SerializeField] private TextMeshProUGUI pointText;

    // Update is called once per frame
    void Update()
    {
        pointText.text = "Points:" + GameManager.Instance.point;
        if (GameManager.Instance.point == 6)
        {
            GameManager.Instance.LevelUp();
            levels[currentLevel - 1].SetActive(false);
            levels[currentLevel].SetActive(true);
            GameManager.Instance.point = 0;
            currentLevel++;
        }
    }
}
