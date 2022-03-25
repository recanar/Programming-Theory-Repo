using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{

    [SerializeField] private GameObject player;
    [SerializeField] private List<GameObject> playerShapes;

    public Vector3 playerPosition;
    public int point;
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
        GetPlayerShapes();
    }
    public void PlayerShapeChange(string tag)
    {
        for (int i = 0; i < player.transform.childCount; i++)
        {
            if (player.transform.GetChild(i).gameObject.CompareTag(tag))//call new shape with tag paramater
            {
                player.transform.GetChild(i).position = playerPosition;//match new shape with player's current position after change
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
    public void GetPlayerShapes()
    {
        playerShapes = new List<GameObject>();
        for (int i = 0; i < player.transform.childCount; i++)
        {
            playerShapes.Add(player.transform.GetChild(i).gameObject);
        }
    }
}
