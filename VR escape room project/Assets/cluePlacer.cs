using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class cluePlacer : MonoBehaviour
{
    public Rigidbody rb;
    public XRGrabInteractable interactable;
    public MeshCollider mesh;
    public string tag;


    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(tag)) 
        {
            interactable = other.GetComponent<XRGrabInteractable>();
            Destroy(interactable);
            mesh = other.GetComponent<MeshCollider>();
            Destroy(mesh);
            other.transform.position = gameObject.transform.position;
            other.transform.rotation = gameObject.transform.rotation;
            rb = other.GetComponent<Rigidbody>();
            rb.constraints = RigidbodyConstraints.FreezeAll;
            Destroy(gameObject);
        }
    }
}
