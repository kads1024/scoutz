using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashPickup : MonoBehaviour
{
    public TrashManager tm;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            tm.collected++;
            tm.trashes.Remove(gameObject);
            Destroy(gameObject);
            PSFXManager.Instance.PlayPickup();
        }
    }
}
