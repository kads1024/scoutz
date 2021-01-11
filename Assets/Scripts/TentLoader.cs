using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TentLoader : MonoBehaviour
{
    public GameObject BuiltTent;
    public Tent tent;

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("Tent"))
        {
            BuiltTent.SetActive(true);
            Destroy(gameObject);
            tent.interactButton.onClick.RemoveAllListeners();
            tent.interactButton.gameObject.SetActive(false);
        }

    }

    
}
