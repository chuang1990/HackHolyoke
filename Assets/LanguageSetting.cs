using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LanguageSetting : MonoBehaviour
{
    // Start is called before the first frame update
    private string languageSelected;

    public void toProlog() {
    	Text buttonTxt = GetComponentInChildren<Text>();
    	languageSelected = buttonTxt.text;
        SceneManager.LoadScene("PrologueScene");
        
    }

    public string getLanguage() {
    	return languageSelected;
    }
}
