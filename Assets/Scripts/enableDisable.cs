using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableDisable : MonoBehaviour
{
    public GameObject go;
    public SpriteRenderer sr;
    public enableDisable script;
    public AudioSource audioSource;
    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            sr.enabled = false;
            go.SetActive(false);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            sr.enabled = true;
            go.SetActive(true);
            //  go.activeInHierarchy
        }

        if(Input.GetKey(KeyCode.Space))
        {
            if(!audioSource.isPlaying)
            { 
                //audioSource.Play();
                audioSource.PlayOneShot(clip);
            }
            //audioSource.clip.length
        }
    }
}
