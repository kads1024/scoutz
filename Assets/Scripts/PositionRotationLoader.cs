using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionRotationLoader : MonoBehaviour
{
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("px"))
        {
            player.position = new Vector3(float.Parse(PlayerPrefs.GetString("px")), float.Parse(PlayerPrefs.GetString("py")), float.Parse(PlayerPrefs.GetString("pz")));
            player.rotation =  new Quaternion(float.Parse(PlayerPrefs.GetString("rx")), float.Parse(PlayerPrefs.GetString("ry")), float.Parse(PlayerPrefs.GetString("rz")), 1.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetString("px", player.position.x.ToString());
        PlayerPrefs.SetString("py", player.position.y.ToString());
        PlayerPrefs.SetString("pz", player.position.z.ToString());

        PlayerPrefs.SetString("rx", player.rotation.x.ToString());
        PlayerPrefs.SetString("ry", player.rotation.y.ToString());
        PlayerPrefs.SetString("rz", player.rotation.z.ToString());
    }
}
