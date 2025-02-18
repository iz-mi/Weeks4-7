using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawner : MonoBehaviour
{
    public GameObject bubblePrefab;
    public float bubbleSize;

    //create minimum and maximum xy values for random spawn positions
    public Vector2 spawnX = new Vector2(0, 1);
    public Vector2 spawnY = new Vector2(0, 1);

    // set slider function to update bubble size (min 0.1
    public void UpdateBubbleSize(float newSize)
    {
        bubbleSize = newSize;
    }

    //set up on-click behaviour for button ui
    public void spawnBubbleButton()
    {
        //create a random xy coordinate to spawn on
        float randomX = Random.Range(spawnX.x, spawnX.y);
        float randomY = Random.Range(spawnY.x, spawnY.y);

        //set this random xy coordinate to var randomPosition so we can spawn it with an instantiate
        Vector2 randomPosition = new Vector2(randomX, randomY);

        //instantiate a copy of the prefab at generated random position
        GameObject newBubble = Instantiate(bubblePrefab, randomPosition, Quaternion.identity);

        //set the instantiated game object to the scale of the slider
        newBubble.transform.localScale = Vector2.one * bubbleSize;
    }
}