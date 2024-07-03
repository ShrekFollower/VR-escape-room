using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class splat : MonoBehaviour
{

    public AudioSource source;
    public AudioClip clip;

    public void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("FlySwatter")) 
        {
            source.Stop();
            source.clip = clip;
            source.Play();
            Destroy(gameObject);
        }
    }
}
