using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class Button_Trigger : MonoBehaviour
{

    public TMP_Text text;
    public string savedString;
    public string setChar;

    [SerializeField] private bool canPress;
    [SerializeField] private float freezeTime;

    // Start is called before the first frame update
    void Start()
    {
        freezeTime = 0.2f;
        canPress = true;
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Button") && canPress == true) 
        {
            StartCoroutine(deadTIme());
            savedString = text.text.ToString();
            Debug.Log(savedString.Length);
            // makes sure the player can not input more then the max number of 4.
            if(savedString.Length < 4) 
            {
                if (savedString.Length >= 1) ;
                {
                    // sets the code displayed on the screen to the previous code + the number on this button.
                    Debug.Log(savedString.Length);
                    text.SetText(text.text + setChar);
                    Debug.Log("Adding a number");
                }
                if (savedString.Length <= 0)
                {
                    // sets the code displayed on the screen to the number on this button.
                    Debug.Log(savedString.Length);
                    text.SetText(setChar);
                    Debug.Log("First Number");
                }
                else
                {
                }
            }
        }
    }

    public IEnumerator deadTIme() 
    {
        // waits before allowing the button to be pressed again, this helps prevent accidental presses.
        canPress = false;
        yield return new WaitForSeconds(freezeTime);
        canPress = true;
    }
}
