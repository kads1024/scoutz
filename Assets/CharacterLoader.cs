using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLoader : MonoBehaviour
{
    public GameObject boy;
    public GameObject girl;

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetString("Gender") == "Boy")
        {
            boy.SetActive(true);
            girl.SetActive(false);
        }
        else if (PlayerPrefs.GetString("Gender") == "Girl")
        {
            boy.SetActive(false);
            girl.SetActive(true);
        }
    }
}
