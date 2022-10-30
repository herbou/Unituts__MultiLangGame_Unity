# MultiLangGame_Unity
how to make your Unity game Multi-Languages without coding


  * You need to add TextMesh Pro package. because this package is using it.
  

 >> Youtube video tutorial [Multi Launguages Unity Game Without Coding](https://youtu.be/yvpPUTkQFM8) .

 <br>
# How to add variables to your text


1- Add placeholders for variables  <br>
[ en.txt ] : <br>
```GREETING=Hello Mr {0}, your score is: {1}``` <br>
[ fr.txt ] : <br>
```GREETING=Bonjour monsieur {0}, votre score est:  {1}``` <br>



2- Lets suppose you have a UI Text to show this greeting text
you need to translate it in a script:

-----
```c#
using UnityEngine.UI;

public class Test : MonoBehavior {
  public Text uiGreetingText;

  void Start(){
     //use GameMultiLang.GetTraduction(KEY) :
     string greetingText = GameMultiLang.GetTraduction ("GREETING");  

     //GetComponent <Text> ().text = String.Format(greetingText, var0, var1);
     GetComponent <Text> ().text = String.Format(greetingText, "John", 134);
  }
}
```
the result is: <br>
```Hello Mr John, your score is: 134``` <br>
or (in case of FR lang) : <br>
```Bonjour monsieur John, votre score est:  134```


<br><br>
<br>
## ❤️ Donate  
<a href="https://paypal.me/hamzaherbou" title="https://paypal.me/hamzaherbou" target="_blank"><img align="left" height="50" src="https://www.mediafire.com/convkey/72dc/iz78ys7vtfsl957zg.jpg" alt="Paypal"></a>
