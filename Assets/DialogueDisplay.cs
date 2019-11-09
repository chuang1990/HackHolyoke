using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueDisplay : MonoBehaviour
{
	public Conversation conversation;

	public GameObject speakerLeft;
	public GameObject speakerRight;

	private SpeakerUI speakerUILeft;
	private SpeakerUI speakerUIRight;

	private int activeLineIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        speakerUILeft = speakerLeft.GetComponent<SpeakerUI>();
        speakerUIRight = speakerRight.GetComponent<SpeakerUI>();

        speakerUILeft.Speaker = conversation.speakerLeft;
        speakerUIRight.Speaker = conversation.speakerRight;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")) {
        	AdvanceConversation();
        }
    }

    void AdvanceConversation() {
    	if (activeLineIndex < conversation.lines_English.Length) {
    		DisplayLine();
    		activeLineIndex++;
    	}
    	else {
    		speakerUILeft.Hide();
    		speakerUIRight.Hide();
            SceneManager.LoadScene("WillowGhostBattleScene");
    		// activeLineIndex = 0;
    	}
    }

    void DisplayLine() {
        Line line;
        if(LanguageSetting.languageSelected == "English") {
             line = conversation.lines_English[activeLineIndex];
        }
        else if (LanguageSetting.languageSelected == "Hindi") {
             line = conversation.lines_Hindi[activeLineIndex];

        } 
        else if (LanguageSetting.languageSelected == "Chinese"){

             line = conversation.lines_Chinese[activeLineIndex];
        }
        else {
            line = conversation.lines_English[activeLineIndex];
        }
    	
    	Character character = line.character;

    	if(speakerUILeft.SpeakerIs(character)) {
    		SetDialog(speakerUILeft, speakerUIRight, line.text);
    	}
    	else {
    		SetDialog(speakerUIRight, speakerUILeft, line.text);
    	}
    }

    void SetDialog(SpeakerUI activeSpeakerUI,
    				SpeakerUI inactiveSpeakerUI,
    				string text)
    {
    	activeSpeakerUI.Dialog = text;
    	activeSpeakerUI.Show();
    	inactiveSpeakerUI.Hide();
    }
}
