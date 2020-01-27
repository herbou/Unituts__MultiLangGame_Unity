using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LangDropDown : MonoBehaviour
{
	[SerializeField] string[] myLangs;
	Dropdown drp;
	int index;

	void Awake ()
	{
		drp = this.GetComponent <Dropdown> ();
		int v = PlayerPrefs.GetInt ("_language_index", 0);
		drp.value = v;

		drp.onValueChanged.AddListener (delegate {
			index = drp.value;
			PlayerPrefs.SetInt ("_language_index", index);
			PlayerPrefs.SetString ("_language", myLangs [index]);
			Debug.Log ("language changed to " + myLangs [index]);
			//apply changes
			ApplyLanguageChanges ();
		});
	}

	void ApplyLanguageChanges ()
	{
		SceneManager.LoadScene (0);
	}

	void OnDestroy ()
	{
		drp.onValueChanged.RemoveAllListeners ();
	}
}
