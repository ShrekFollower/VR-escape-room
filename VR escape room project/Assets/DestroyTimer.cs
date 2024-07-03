using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTimer : MonoBehaviour
{

    // time before the object is destroyed/
    public float time;

    // Start is called before the first frame update
    void Start()
    {
        // starts the delay before the object is destroyed.
        StartCoroutine(destroy());
    }

    public IEnumerator destroy() 
    {
        // waits for the time set on the float variable
        yield return new WaitForSeconds(time);
        // destroys this game object.
        Destroy(gameObject);
    }
}
