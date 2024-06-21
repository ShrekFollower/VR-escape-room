using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortManager : MonoBehaviour
{

    public float Audio;
    public float Video;
    public float Private;

    public float fileMax;
    
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void checkIfTrue()
    {
        if(Audio == 4 && Video == 4 && Private == 4)
        {
            anim.SetBool("play" , true);
            Debug.Log("Sorting Completed!");
        }

        else
        {
            Debug.Log("Sorting Incomplete...");
        }
    }

}
