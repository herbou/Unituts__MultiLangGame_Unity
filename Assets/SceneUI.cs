using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneUI : MonoBehaviour
{
	void Start ()
	{
		Debug.Log (GameMultiLang.GetTraduction ("HELLO"));
	}

	public void SwitchScene ()
	{
		if (SceneManager.GetActiveScene ().buildIndex == 0)
			SceneManager.LoadScene (1);
		else
			SceneManager.LoadScene (0);
	}
}
