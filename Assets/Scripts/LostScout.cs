using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LostScout : MonoBehaviour
{
    private void Start ()
    {
        if (PlayerPrefs.HasKey("Lost"))
        {
            Destroy(this);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            PlayerPrefs.SetInt("Lost", 1);
            Destroy(this);
            SceneManager.LoadScene("MainWorld");
        }
    }
}
