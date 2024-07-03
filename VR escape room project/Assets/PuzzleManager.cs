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

    public void puzzleStages() 
    {
        if (piecesPlaced == 4) 
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
            Debug.Log("First puzzle completed");
        }

        if (piecesPlaced == 8)
        {
            foreach (GameObject g in thirdPuzzle)
            {
                g.SetActive(true);
            }
            foreach (GameObject g in secondPuzzle)
            {
                g.SetActive(false);
            }
            Debug.Log("Second puzzle completed");
        }

        if (piecesPlaced == 12)
        {
            foreach (GameObject g in thirdPuzzle)
            {
                g.SetActive(false);
            }
            flyswatter.SetActive(true);
            note.SetActive(true);
            Debug.Log("Third puzzle completed");
        }

        else 
        {
            Debug.Log("No milestone reached");
        }

    }

}
