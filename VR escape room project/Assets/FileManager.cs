using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class FileManager : MonoBehaviour
{

    public float restored;
    public float maxRestored;
    public Button_Collider[] buttons;
    public Animator[] animator;
    public VideoPlayer player;
    public VideoClip clip;
    public GameObject ErrorScreen;
    public float crashTime;
    public Speaker speaker;


    public void Error() 
    {
        foreach(Button_Collider b in buttons) 
        {
            // resets all files to their original state as well as resetting the number of files restored.
            b.Purge();
            Debug.Log("file purged");
        }
        StartCoroutine(Bluescreen());
    }

    public IEnumerator Bluescreen() 
    {
        // displays error screen until timer is up.
        ErrorScreen.SetActive(true);
        yield return new WaitForSeconds(crashTime);
        ErrorScreen.SetActive(false);
    }

    public void checkIfComplete() 
    {
        if(restored >= maxRestored) 
        {
            // sets the video clip on the monitors to the new clip and plays it.
            player.clip = clip;
            player.Play();
            // plays the animation for all animators within the animator array, in this case the one on the panels and tube.
            foreach(Animator a in animator) 
            {
                a.SetBool("Play", true);
                speaker.isNormal = false;
            }
        }
    }

}
