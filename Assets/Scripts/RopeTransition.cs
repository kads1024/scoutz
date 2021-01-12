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
        if (NextOne == "Dialogue3")
        {
            
            PlayerPrefs.SetInt("Rope", 1);
        }
        SceneManager.LoadScene(NextOne);
        
    }
}
