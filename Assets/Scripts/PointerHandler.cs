using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerHandler : MonoBehaviour
{
    public bool pointerdown;
    public bool pointerhold;

    public void OnPointerDown()
    {
        pointerhold = true;
        pointerdown = true;
    }

    public void OnPointerUp()
    {
        pointerhold = false;
    }
}
