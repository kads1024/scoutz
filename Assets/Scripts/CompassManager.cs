using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompassManager : MonoBehaviour
{
    public List<Transform> player;
    public Transform compass;
    public int offset;
    Vector3 dir;

    int character;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetString("Gender") == "Boy") character = 0;
        else if (PlayerPrefs.GetString("Gender") == "Girl") character = 1;
    }

    // Update is called once per frame
    void Update()
    {
        dir.z = player[character].eulerAngles.y + offset;
        compass.eulerAngles = -dir;
    }
}
