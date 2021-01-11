using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TaskManager : MonoBehaviour
{
    public TextMeshProUGUI task;
    public GameObject trash;
    public GameObject lostScout;

    public Vector3 LostPos;
    public Vector3 FoundPos;

    // Update is called once per frame
    void Update()
    {
        if(!PlayerPrefs.HasKey("Rope"))
        {
            task.text = "TIE A BOWLINE KNOT";
            lostScout.transform.position = LostPos;
            trash.SetActive(false);
            lostScout.SetActive(false);
        }
        else if (!PlayerPrefs.HasKey("Tent"))
        {
            task.text = "SETUP YOUR TENT";
            lostScout.transform.position = LostPos;
            trash.SetActive(false);
            lostScout.SetActive(false);
        }
        else if (!PlayerPrefs.HasKey("Trash"))
        {
            task.text = "COLLECT TRASH";
            lostScout.transform.position = LostPos;
            trash.SetActive(true);
            lostScout.SetActive(false);
        }
        else if (!PlayerPrefs.HasKey("Lost"))
        {
            task.text = "FIND THE LOST SCOUT AT NORTH-EAST";
            lostScout.transform.position = LostPos;
            trash.SetActive(false);
            lostScout.SetActive(true);
        }
        else
        {
            task.text = "END";
            lostScout.transform.position = FoundPos;
            trash.SetActive(false);
            lostScout.SetActive(true);
        }
    }
}
