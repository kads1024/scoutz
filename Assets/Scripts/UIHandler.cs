using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIHandler : MonoBehaviour
{
    public GameObject Settings;
    public GameObject MusicOn;
    public GameObject MusicOff;
    public GameObject SoundOn;
    public GameObject SoundOff;

    public GameObject Slot;
    public GameObject Badges;

    public void OnStart()
    {
        if(PlayerPrefs.HasKey("Gender"))
        {
            SceneManager.LoadScene("MainWorld");
        }
        else
        {
            SceneManager.LoadScene("CharacterSelection");
        }
    }

    public void OnBadges()
    {
        Badges.SetActive(!Badges.activeInHierarchy);
    }

    public void OnExit()
    {
        Application.Quit();
    }

    public void OnSettings()
    {
        Time.timeScale = 0;
        Settings.SetActive(true);
    }

    public void OnMusic()
    {
        MusicOn.SetActive(!MusicOn.activeInHierarchy);
        MusicOff.SetActive(!MusicOff.activeInHierarchy);
    }

    public void OnSound()
    {
        SoundOn.SetActive(!SoundOn.activeInHierarchy);
        SoundOff.SetActive(!SoundOff.activeInHierarchy);
    }

    public void OnOkay()
    {
        Time.timeScale = 1;
        Settings.SetActive(false);
    }

    public void OnCharacterSelect()
    {
        SceneManager.LoadScene("CharacterSelection");
    }

    public void Cutscene()
    {
        SceneManager.LoadScene("Cutscene");
    }

    public void OnMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void OnBowline()
    {
        SceneManager.LoadScene("BowlineKnot");
    }

    public void OnInventory()
    {
        Slot.SetActive(!Slot.activeInHierarchy);
    }

    public void OnSelectGender(string gender)
    {
        PlayerPrefs.SetString("Gender", gender);
        OnStart();
    }
    public void OnResetData()
    {
        PlayerPrefs.DeleteAll();
    }
}


