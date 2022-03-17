using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public int point;
    public int numPickups=6;
    public TextMeshProUGUI pointText;

    public GameObject player;
    public List<GameObject> playerShapes;
    public Vector3 playerPosition;
    int currentLevel = 1;
    [SerializeField]GameObject[] levels;
    public static GameManager Instance { get; private set; }
    private void Awake()
    {
        //singleton
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }
    private void Start()
    {
        playerShapes = new List<GameObject>();
        for (int i = 0; i < player.transform.childCount; i++)
        {
            playerShapes.Add(player.transform.GetChild(i).gameObject);
        }
    }
    private void FixedUpdate()
    {
        pointText.text = "Points:" + point;
        if (point == 6)
        {
            LevelUp();
            levels[currentLevel - 1].SetActive(false);
            levels[currentLevel].SetActive(true);
            point = 0;
            currentLevel++;
        }
    }
    public void PlayerShapeChange(string tag)
    {
        for (int i = 0; i < player.transform.childCount; i++)
        {
            if (player.transform.GetChild(i).gameObject.CompareTag(tag))
            {
                player.transform.GetChild(i).position = playerPosition;
                player.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
    }
    public void IncreasePoint()
    {
        point++;
    }
    public void LevelUp()
    {
        for (int i = 0; i < playerShapes.Count; i++)
        {
            playerShapes[i].transform.position = Vector3.up;
        }
    }
}
