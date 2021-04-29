using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TentDone : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        StartCoroutine(Done());
    }


    IEnumerator Done()      
    {
        yield return new WaitForSeconds(2.0f);
        PlayerPrefs.SetInt("Tent", 1);

        if (PlayerPrefs.GetInt("FromBadges") == 0)
        {
            SceneManager.LoadScene("Dialogue4");
        }
        else if (PlayerPrefs.GetInt("FromBadges") == 1)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
