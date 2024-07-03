using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glass : MonoBehaviour
{

    public GameObject fractured;
    public GameObject note;
    public float breakforce;

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided");
        // activates if the hammer hits it.
        if (other.CompareTag("Hammer")) 
        {
            // spawns in the fractured version of the glass in the same position and rotation as the normal one.
            GameObject fracture = Instantiate(fractured, transform.position, transform.rotation);
            // pushes each piece of the broken glass model in different directions to simulate it being broken.
            foreach (Rigidbody rb in fracture.GetComponentsInChildren<Rigidbody>())
            {
                Vector3 force = (rb.transform.position - transform.position).normalized * breakforce;
                rb.AddForce(force);
            }
            // spawn in the note in the sane position as this object.
            Instantiate(note, transform.position, transform.rotation);
            // destroys the unbroken glass object.
            Destroy(gameObject);
        }
    }
}
