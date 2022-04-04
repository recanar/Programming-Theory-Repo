using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject levels;
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject menuObjects;//some in game objects from game to increase visuals
    public void StartGame()
    {
        SceneManager.LoadScene("Level1");
    }
    public void LevelSelectScreen ()
    {
        mainMenu.SetActive(false);
        menuObjects.SetActive(false);
        levels.SetActive(true);
    }
    public void BackToMenu()
    {
        levels.SetActive(false);
        mainMenu.SetActive(true);
        menuObjects.SetActive(true);
    }
}
