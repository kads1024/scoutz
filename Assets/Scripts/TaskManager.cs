using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TaskManager : MonoBehaviour
{
    public TextMeshProUGUI task;
    public GameObject trash;
    public List<GameObject> lostScout;

    public Vector3 LostPos;
    public Vector3 FoundPos;
    int character;

    private void Start()
    {
        if (PlayerPrefs.GetString("Gender") == "Boy") character = 0;
        else if (PlayerPrefs.GetString("Gender") == "Girl") character = 1;
    }
    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.HasKey("TrashBadge"))
        {
            task.text = "COLLECT TRASH";
            lostScout[character].transform.position = LostPos;
            trash.SetActive(true);
            lostScout[character].SetActive(false);
        }
        else if(PlayerPrefs.HasKey("LostBadge"))
        {
            task.text = "FIND THE LOST SCOUT AT NORTH-EAST";
            lostScout[character].transform.position = LostPos;
            trash.SetActive(false);
            lostScout[character].SetActive(true);
        }
        else
        {
            if (!PlayerPrefs.HasKey("Rope"))
            {
                task.text = "TIE A BOWLINE KNOT";
                lostScout[character].transform.position = LostPos;
                trash.SetActive(false);
                lostScout[character].SetActive(false);
            }
            else if (!PlayerPrefs.HasKey("Tent"))
            {
                task.text = "SETUP YOUR TENT";
                lostScout[character].transform.position = LostPos;
                trash.SetActive(false);
                lostScout[character].SetActive(false);
            }
            else if (!PlayerPrefs.HasKey("Trash"))
            {
                task.text = "COLLECT TRASH";
                lostScout[character].transform.position = LostPos;
                trash.SetActive(true);
                lostScout[character].SetActive(false);
            }
            else if (!PlayerPrefs.HasKey("Lost"))
            {
                task.text = "FIND THE LOST SCOUT AT NORTH-EAST";
                lostScout[character].transform.position = LostPos;
                trash.SetActive(false);
                lostScout[character].SetActive(true);
            }
            else
            {
                task.text = "END";
                lostScout[character].transform.position = FoundPos;
                trash.SetActive(false);
                lostScout[character].SetActive(true);
            }
        }
    }
}
