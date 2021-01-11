using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StakeCounter : MonoBehaviour
{
    public int count;
    public GameObject Step3;
    public List<GameObject> prevStep;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(count >= 4)
        {
            Step3.SetActive(true);
            Destroy(gameObject);

            foreach(GameObject ob in prevStep)
            {
                Destroy(ob);
            }
            
        }
    }
}
