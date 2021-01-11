using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompassManager : MonoBehaviour
{
    public Transform player;
    public Transform compass;
    public int offset;
    Vector3 dir;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dir.z = player.eulerAngles.y + offset;
        compass.eulerAngles = -dir;
    }
}
