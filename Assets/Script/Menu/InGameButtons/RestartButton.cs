using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartButton : MonoBehaviour
{
	private Button btn;
	void Start()
	{
		btn = gameObject.GetComponent<Button>();
		btn.onClick.AddListener(RestartLevel);
	}
	void RestartLevel()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
