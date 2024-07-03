using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speaker : MonoBehaviour
{

    public AudioSource source;
    public AudioClip[] clipsNormal;
    public AudioClip[] clipsSqueeky;
    public AudioClip previousClip;
    public bool isNormal;
    public float waitTime;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        StartCoroutine(changeLine());
    }

    public IEnumerator changeLine() 
    {
        if (isNormal) 
        {
            // chooses a random clip from the normal lines before playing it and resetting the wait time.
            source.clip = clipsNormal[Random.Range(0,4)];
            if(source.clip == previousClip ) 
            {
                changeLine();
            }
            else 
            {
                source.Play();
                previousClip = source.clip;
                yield return new WaitForSeconds(waitTime);
                StartCoroutine(changeLine());
            }
        }
        else 
        {
            // chooses a random clip from the squeaky lines before playing it and resetting the wait time.
            source.clip = clipsSqueeky[Random.Range(0,4)];
            if (source.clip == previousClip)
            {
                changeLine();
            }
            else
            {
                source.Play();
                previousClip = source.clip;
                yield return new WaitForSeconds(waitTime);
                StartCoroutine(changeLine());
            }
        }
    }
}
