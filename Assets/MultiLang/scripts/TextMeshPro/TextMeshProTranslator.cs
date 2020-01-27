using UnityEngine;
using TMPro;

//text component is required in this gameobject
[RequireComponent (typeof(TMP_Text))]
public class TextMeshProTranslator : MonoBehaviour
{

	[Tooltip ("enter one of the keys that you specify in your (txt) file for all languages.\n\n# for example: [HOME=home]\n# the key here is [HOME]")]
	[Header ("Enter your word key here.")]
	[SerializeField] 
	string key;

	void Start ()
	{
		GetComponent <TMP_Text> ().text = GameMultiLang.GetTraduction (key);
	}
}
