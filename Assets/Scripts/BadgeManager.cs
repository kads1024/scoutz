using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BadgeManager : MonoBehaviour
{
    public Image ropeWork;
    public Image carpentry;
    public Image cleanup;
    public Image pathfind;

    // Start is called before the first frame update
    void Start()
    {
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
    }


}
