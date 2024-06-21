using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortScript : MonoBehaviour
{

    [SerializeField] private string tagName;
    public float fileCount;

    public GameObject sortObject;
    public SortManager sortMng;

    public float tagName;

    public void Start()
    {
        sortMng = sortObject.GetComponent<SortManager>();
    }

    public void OnTriggerEnter(Collider other)
    {
        //checks if the tag is the same as the one for this colldier.
        if (other.CompareTag(tagName)) 
        {
            //if the tag is the same the it adds 1 to the file count.
            fileCount++;
            sortMng.tagName ++;
            sortMng.tagName.String ++;
            sortMng.checkIfTrue();
        }
    }

    public void OnTriggerExit(Collider other)
    {
        // checks if the tag is the same as the one set for this collider.
        if (other.CompareTag(tagName))
        {
            //takes away 1 from the file count.
            fileCount--;
        }
    }
}
