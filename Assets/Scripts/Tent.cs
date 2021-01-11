using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Tent : MonoBehaviour
{
    public Button interactButton;
    public TextMeshProUGUI interacText;

    private void Start()
    {
        
    }

    private void GoToTent()
    {
        SceneManager.LoadScene("Tent");
    }

    private void OnTriggerEnter(Collider other)
    {

        if(other.tag == "Player" && !PlayerPrefs.HasKey("Tent") && PlayerPrefs.HasKey("Rope"))
        {
            interacText.text = "BUILD TENT";
            interactButton.onClick.AddListener(GoToTent);
            interactButton.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" && !PlayerPrefs.HasKey("Tent") && PlayerPrefs.HasKey("Rope"))
        {
            interactButton.onClick.RemoveAllListeners();
            interactButton.gameObject.SetActive(false);
        }
    }
}
