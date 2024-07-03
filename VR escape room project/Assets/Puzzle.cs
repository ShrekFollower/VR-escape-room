using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class Puzzle : MonoBehaviour
{

    public GameObject thisPiece;
    public Rigidbody rb;
    public XRGrabInteractable interactable;
    public MeshCollider mesh;
    public string thisTag;

    public PuzzleManager manager;

    public void Awake()
    {
        Debug.Log("Puzzle started");
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision");
        if (other.CompareTag(thisTag)) 
        {
            interactable = other.GetComponent<XRGrabInteractable>();
            Destroy(interactable);
            mesh = other.GetComponent<MeshCollider>();
            Destroy(mesh);
            other.transform.position = gameObject.transform.position;
            other.transform.rotation = gameObject.transform.rotation;
            rb = other.GetComponent<Rigidbody>();
            rb.constraints = RigidbodyConstraints.FreezeAll;
            manager.piecesPlaced++;
            manager.puzzleStages();
            gameObject.SetActive(false);
        }
    }

}
