using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] int point;
    int countThisLevelPoints;
    public static LevelManager InstanceLevel { get; private set; }

    public int numPickups = 6;
    [SerializeField] private TextMeshProUGUI pointText;
    private void Awake()
    {
        //singleton
        if (InstanceLevel != null)
        {
            Destroy(gameObject);
            return;
        }

        InstanceLevel = this;
    }
    private void Start()
    {
        point = 0;
        countThisLevelPoints = GameObject.FindGameObjectsWithTag("Point").Length;
    }
    void Update()
    {
        pointText.text = "Points:" +point+ "/"+ countThisLevelPoints;
        
        CheckLevelUpWithPoint();
    }
    void CheckLevelUpWithPoint()
    {
        if (point == countThisLevelPoints)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }
    public void IncreasePoint()
    {
        point++;
    }
}
