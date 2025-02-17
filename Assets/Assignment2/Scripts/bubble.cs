using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubble : MonoBehaviour
{
    //set up timer before bubble pops by itself
    public float popTime = 5f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //reduce popTime each frame, destroy instantiated gameObject once popTime==0
        popTime -= Time.deltaTime;
        if (popTime <= 0)
        {
            Destroy(gameObject);
        }
    }
}
