using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class LanguageSetting : MonoBehaviour
{
    // Start is called before the first frame update
    public static string languageSelected;

    public void toProlog() {

    	// Text buttonTxt = GetComponentInChildren<Text>();
        string buttonClicked = EventSystem.current.currentSelectedGameObject.name;
    	Debug.Log("Button Clicked: " + buttonClicked);
        if (buttonClicked == "ChineseButton"){
            languageSelected = "Chinese";
        }
        if (buttonClicked == "EnglishButton"){
            languageSelected = "English";
        }
        if (buttonClicked == "HindiButton") {
            languageSelected = "Hindi";
        }
        Debug.Log("Language selected by user: " + languageSelected);
        SceneManager.LoadScene("PrologueScene");
        
    }

    public string getLanguage() {
    	return languageSelected;
    }
}
