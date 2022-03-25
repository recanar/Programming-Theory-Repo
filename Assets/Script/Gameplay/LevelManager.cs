using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] List<GameObject> levels;
    int currentLevel=1;

    public int numPickups = 6;
    [SerializeField] private TextMeshProUGUI pointText;

    private void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            levels.Add(transform.GetChild(i).gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        pointText.text = "Points:" + GameManager.Instance.point+"/6";
        LevelUpWithPoint();
    }
    void LevelUpWithPoint()
    {
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
