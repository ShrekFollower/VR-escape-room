using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wait_before_active : MonoBehaviour
{

    public float time;
    public GameObject target;

    public void Start()
    {
        StartCoroutine(wait());
    }

    public IEnumerator wait() 
    {
        yield return new WaitForSeconds(time);
        target.SetActive(true);
    }
}
