using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputColl : MonoBehaviour
{

    public TMP_Text text;
    public string savedString;
    public string answer;
    public GameObject forceField;
    public AudioClip begging;
    public AudioSource roachSource;
    public Speaker speaker;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Button")) 
        {
            savedString = text.text.ToString();
            Debug.Log(savedString.Length);
            if(savedString == answer) 
            {
                text.text = "Correct";
                forceField.SetActive(false);
                speaker.enabled = false;
                roachSource.Stop();
                roachSource.clip = begging;
                roachSource.Play();
            }

            else
            {
                StartCoroutine(incorrect());
            }
        }
    }

    public IEnumerator incorrect() 
    {
        text.text = "Wrong";
        yield return new WaitForSeconds(1);
        text.text = "";
    }
}
