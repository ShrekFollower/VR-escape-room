using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Collider : MonoBehaviour
{

    [SerializeField] private Image progressBar;
    [SerializeField] private float progress;
    [SerializeField] private float progressMax;
    [SerializeField] private bool isCorrupt;
    public Image file;
    public Sprite ogSprite;
    public Sprite newSprite;
    public FileManager fileManager;

    public Image buttonImage;
    public Button button;
    public GameObject text;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        buttonImage = GetComponent<Image>();
        progressBar.fillAmount = 0;
    }

    // I needed to create a void function because the button would not let me select the IEnumerator as its click effect.
    public void Restore()
    {
        // starts restoring the file
        StartCoroutine(startRestoring());
    }

    public void Purge() 
    {
        // Changes the sprite back to normal and makes the button visible again.
        file.sprite = ogSprite;
        button.enabled = true;
        buttonImage.enabled = true;
        text.SetActive(true);
    }

    public IEnumerator startRestoring() 
    {
        while(progress <= progressMax) 
        {
            progress += Time.deltaTime;
            progressBar.fillAmount = progress / progressMax;
            yield return new WaitForEndOfFrame();
        }
        
        if(progress >= progressMax) 
        {
            if(isCorrupt) 
            {
                // if this file is corrupt, changes sprite to the fixed one, disables unneeded UI and adds to the files restored.
                fileManager.restored = fileManager.restored + 1;
                file.sprite = newSprite;
                button.enabled = false;
                buttonImage.enabled = false;
                text.SetActive(false);
                fileManager.checkIfComplete();
                Debug.Log("Corrupt file was restored");
            }

            else 
            {
                // resets progress and starts an error.
                fileManager.restored = 0;
                fileManager.Error();
                Debug.Log("Attempted to restore an intact file");
            }
        }
    }
}
