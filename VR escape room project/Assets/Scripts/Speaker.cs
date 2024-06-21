using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speaker : MonoBehaviour
{

    public AudioSource source;
    public AudioClip[] clipsNormal;
    public AudioClip[] clipsSqueeky;
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
            source.clip = clipsNormal[Random.Range(0,4)];
            source.Play();
            yield return new WaitForSeconds(waitTime);
            StartCoroutine(changeLine());
        }
        else 
        {
            source.clip = clipsSqueeky[Random.Range(0,4)];
            source.Play();
            yield return new WaitForSeconds(waitTime);
            StartCoroutine(changeLine());
        }
    }
}
