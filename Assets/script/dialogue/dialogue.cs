using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using UnityEngine.UI;

public class dialogue : MonoBehaviour
{
    public TextMeshProUGUI txt;
    public List<string> textLog = new List<string>();
    public List<Image> character = new List<Image>();
    public List<Sprite> deselectedCharacter = new List<Sprite>();
    public List<Sprite> selectedCharacter = new List<Sprite>();
    public List<int> speakerSquence = new List<int>();
    int textLogNum = -1;
    public float textSpeed;
    float ctr;
    int textCtr = 0;

    bool playingDialogue;

    public string NextScene;

    // Start is called before the first frame update
    void Start()
    {
        nextDialogue();
    }

    // Update is called once per frame
    void Update()
    {
       
            playText();
        
    }
    
    void playText()
    {
        if(textLogNum < textLog.Count)
        {
            if (textCtr < textLog[textLogNum].Length)
            {
                if (ctr < textSpeed)
                {
                    ctr += Time.deltaTime;
                }
                else
                {
                    txt.text += textLog[textLogNum][textCtr] + "";
                    textCtr++;
                    ctr = 0;

                }
            }
        }   
    }



    public void nextDialogue()
    {
        textLogNum++;
        if (textLogNum < textLog.Count)
        {
            
            txt.text = "";
            textCtr = 0;

            if (speakerSquence[textLogNum] == 0)
            {
                character[0].overrideSprite = selectedCharacter[0];
                character[1].overrideSprite = deselectedCharacter[1];
            }
            else if (speakerSquence[textLogNum] == 1)
            {
                character[0].overrideSprite = deselectedCharacter[0];
                character[1].overrideSprite = selectedCharacter[1];
            }

          //  Debug.Log("Hit");
           
        }
        else
        {
            SceneManager.LoadScene(NextScene);
        }
    }



}
