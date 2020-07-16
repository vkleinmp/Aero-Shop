using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Clock : MonoBehaviour
{
    public TMP_Text clockText;

    // Update is called once per frame
    void Update()
    {
        clockText.text = "30";
        //DateTime.Now.ToString();
    }
}
