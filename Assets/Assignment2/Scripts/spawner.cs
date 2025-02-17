using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject bubblePrefab;

    //create minimum and maximum x/y values for random spawn positions
    public Vector2 spawnX = new Vector2(-10f, 10f);
    public Vector2 spawnY = new Vector2(-10f, 10f);

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    public void Update()
    {

    }

    public void spawnBubbleButton()
    {
        //create a random xy coordinate to spawn on
        float randomX = Random.Range(spawnX.x, spawnX.y);
        float randomY = Random.Range(spawnY.x, spawnY.y);

        //set this random xy coordinate to var randomPosition so we can spawn it with an instantiate
        Vector2 randomPosition = new Vector2(randomX, randomY);

        //instantiate a copy of the prefab at generated random position
        Instantiate(bubblePrefab, randomPosition, Quaternion.identity);
    }
}