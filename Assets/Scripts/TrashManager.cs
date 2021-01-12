using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TrashManager : MonoBehaviour
{
    public Transform Compass;
    public Transform Player;
    public List<GameObject> trashes;
    public int offset;

    public List<Sprite> numbers;
    public int collected;
    public Image numberobj;
    public GameObject UI;

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
            SceneManager.LoadScene("Dialogue5");
        }
    }
}
