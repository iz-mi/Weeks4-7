using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject bubblePrefab;
    public Vector2 spawnXY = new Vector2(10f, 10f);

    //float spawnX = Random.Range();
    //float spawnY = Random.Range();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //spawnX = Math.Random()
            //spawnY = Math.Random()
            Vector2 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(bubblePrefab, mouse, Quaternion.identity);
            //Instantiate(bubblePrefab);
        }
    }
}
