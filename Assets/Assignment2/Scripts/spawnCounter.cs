using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class spawnCounter : MonoBehaviour
{
    //set initial clicks to 0
    public int count = 0;

    //set up button on-click functionality
    public void CounterUp()
    {
        //increase int of total bubbles spawned by +1
        count++;

        //use getcomponent to get the text component from the attached gameobject
        TextMeshProUGUI counterText = GetComponent<TextMeshProUGUI>();

        //display total bubbles spawned as text
        counterText.text = "Total Bubbles Made:" + count;
    }
}
