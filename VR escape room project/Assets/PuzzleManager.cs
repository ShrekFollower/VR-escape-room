using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{

    public GameObject[] firstPuzzle;
    public GameObject[] secondPuzzle;
    public GameObject[] thirdPuzzle;
    public GameObject note;
    public GameObject flyswatter;
    public float piecesPlaced;
    public bool canDelay;

    public void puzzleStages() 
    {
        if (piecesPlaced == 4) 
        {
            if(canDelay != true) 
            {
                foreach (GameObject b in secondPuzzle)
                {
                    b.SetActive(true);
                    Debug.Log("Second puzzle started");
                }
                foreach (GameObject g in firstPuzzle)
                {
                    g.SetActive(false);
                }
                canDelay = true;
                Debug.Log("First puzzle completed");
            }

            else if(canDelay)
            {
                StartCoroutine(Delay());
            }
        }

        if (piecesPlaced == 8)
        {
            if (canDelay != true) 
            {
                foreach (GameObject g in thirdPuzzle)
                {
                    g.SetActive(true);
                }
                foreach (GameObject g in secondPuzzle)
                {
                    g.SetActive(false);
                }
                canDelay = true;
                Debug.Log("Second puzzle completed");
            }
            else if (canDelay) 
            {
                StartCoroutine(Delay());
            }
        }

        if (piecesPlaced == 12)
        {
            if (canDelay != true) 
            {
                foreach (GameObject g in thirdPuzzle)
                {
                    g.SetActive(false);
                }
                flyswatter.SetActive(true);
                note.SetActive(true);
                Debug.Log("Third puzzle completed");
            }
            else if (canDelay) 
            {
                StartCoroutine(Delay());
            }
        }

        else 
        {
            Debug.Log("No milestone reached");
        }

    }

    public IEnumerator Delay() 
    {
        yield return new WaitForSeconds(2);
        canDelay = false;
        puzzleStages();
    }

}
