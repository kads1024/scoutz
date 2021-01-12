using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Instructions : MonoBehaviour
{
    public TextMeshProUGUI instructions;
    public string instructs;
    private void OnEnable()
    {
        instructions.text = instructs;
    }
}
