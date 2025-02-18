using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawnCounter : MonoBehaviour
{
    public Text counterText;
    public int count = 0;

    public void CounterUp()
    {
        count++;
        counterText.text = "Total Bubbles Made:" + count;
    }
}
