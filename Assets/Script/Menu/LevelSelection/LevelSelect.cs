using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
	public Button btn;

	void Start()
	{
		btn = gameObject.GetComponent<Button>();
		btn.onClick.AddListener(ChooseLevel);
	}

	void ChooseLevel()
	{
		SceneManager.LoadScene("Level"+gameObject.name);//go to level of this button name
	}
}
