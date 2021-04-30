using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BadgeManager : MonoBehaviour
{
    public Image ropeWork;
    public Image carpentry;
    public Image cleanup;
    public Image pathfind;
    public GameObject bMenu;

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("TrashBadge"))
        {
            PlayerPrefs.DeleteKey("TrashBadge");
            PlayerPrefs.Save();
        }
        

        if (!PlayerPrefs.HasKey("FromBadges"))
        {
            PlayerPrefs.SetInt("FromBadges", 0);
        }

        if (PlayerPrefs.HasKey("Rope"))
        {
            ropeWork.gameObject.SetActive(true);
        }
        if (PlayerPrefs.HasKey("Tent"))
        {
            carpentry.gameObject.SetActive(true);
        }
        if (PlayerPrefs.HasKey("Trash"))
        {
            cleanup.gameObject.SetActive(true);
        }
        if (PlayerPrefs.HasKey("Lost"))
        {
            pathfind.gameObject.SetActive(true);
        }

        if(PlayerPrefs.GetInt("FromBadges") == 1)
        {
            bMenu.SetActive(true);
            PlayerPrefs.SetInt("FromBadges", 0);
        }
    }

    public void OpenRope()
    {
        PlayerPrefs.SetInt("FromBadges", 1);
        SceneManager.LoadScene("BowlineKnot");
    }

    public void OpenTent()
    {
        PlayerPrefs.SetInt("FromBadges", 1);
        SceneManager.LoadScene("Tent");
    }
    public void OpenTrash()
    {
        PlayerPrefs.SetInt("FromBadges", 1);
        PlayerPrefs.SetInt("TrashBadge", 1);
        SceneManager.LoadScene("MainWorld");
    }

    public void OpenLost()
    {
        PlayerPrefs.SetInt("FromBadges", 1);
        PlayerPrefs.SetInt("LostBadge", 1);
        SceneManager.LoadScene("MainWorld");
    }
}
