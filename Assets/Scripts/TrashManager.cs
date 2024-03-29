﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TrashManager : MonoBehaviour
{
    public Transform Compass;
    public List<Transform> Player;
    public List<GameObject> trashes;
    public int offset;

    public List<Sprite> numbers;
    public int collected;
    public Image numberobj;
    public GameObject UI;

    int character;
    private void Start()
    {
        if (PlayerPrefs.GetString("Gender") == "Boy") character = 0;
        else if (PlayerPrefs.GetString("Gender") == "Girl") character = 1;
    }
    // Start is called before the first frame update
    void OnEnable()
    {
        UI.SetActive(true);
    }

    private void OnDisable()
    {
        UI?.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if(collected <= 10) numberobj.overrideSprite = numbers[collected];
        if (collected >= 10)
        {
            PlayerPrefs.SetInt("Trash", 1);
            PlayerPrefs.DeleteKey("TrashBadge");
            PlayerPrefs.Save();
            if(PlayerPrefs.GetInt("FromBadges") == 0)
                SceneManager.LoadScene("Dialogue5");
            else
                SceneManager.LoadScene("MainMenu");
        }
    }
}
