using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RopeTransition : MonoBehaviour
{
    public string NextOne;
    

    public void Ready()
    {
        if (!GetComponent<Button>().interactable)
         GetComponent<Button>().interactable = true;
    }

    public void OnNext()
    {
        Debug.Log(NextOne);
        Debug.Log(PlayerPrefs.GetInt("FromBadges"));
        if (NextOne == "Dialogue3")
        {
            PlayerPrefs.SetInt("Rope", 1);
            if (PlayerPrefs.GetInt("FromBadges") == 0)
            {
                SceneManager.LoadScene(NextOne);
            }
            else if (PlayerPrefs.GetInt("FromBadges") == 1)
            {
                SceneManager.LoadScene("MainMenu");
            }
        }
        else
        {
            SceneManager.LoadScene(NextOne);
        }
    }
}
