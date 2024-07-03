using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortManager : MonoBehaviour
{

    //current files sorted and the max before the goal is complete.
    public float filesSorted;
    public float fileMax;
    
    //animator for the hidden panel
    public Animator anim;

    public void checkIfTrue()
    {
        // adds 1 to the current sorted files.
        filesSorted++;

        // checks if the current sorted files is the same as the maximum.
        // If this is true then it opens the hidden panel by setting the animator to play.
        if(filesSorted == fileMax)
        {
            anim.SetBool("Play" , true);
            Debug.Log("Sorting Completed!");
        }

        else
        {
            // if it is not complete then nothing happens.
            Debug.Log("Sorting Incomplete...");
        }
    }

}
