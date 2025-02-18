using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubble : MonoBehaviour
{
    //set up timer before bubble pops by itself
    public float popTime = 3f;
    
    //set up bubble movement
    float speed =  2;

    // Update is called once per frame
    void Update()
    {
        //bubbles float upwards
        Vector2 position = transform.position;
        position.y += speed * Time.deltaTime;
        transform.position = position;

        //timer, reduces popTime each frame, destroy instantiated gameObject once it reaches 0
        popTime -= Time.deltaTime;
        if (popTime <= 0)
        {
            Destroy(gameObject);
        }
    }
}
