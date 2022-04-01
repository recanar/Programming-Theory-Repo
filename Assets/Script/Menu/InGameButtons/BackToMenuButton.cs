using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackToMenuButton : MonoBehaviour
{
	private Button btn;

	void Start()
	{
		btn = gameObject.GetComponent<Button>();
		btn.onClick.AddListener(BackToMenu);
	}

	void BackToMenu()
	{
		SceneManager.LoadScene(0);
	}
}
