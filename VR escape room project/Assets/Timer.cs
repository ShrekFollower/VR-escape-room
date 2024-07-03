using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public TMP_Text timerText;
    public float time;
    public string scene;

    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(time > 0) 
        {
            time -= Time.deltaTime;
        }
        if(time <= 0) 
        {
            SceneManager.LoadScene(scene);
        }
        int Minutes = Mathf.FloorToInt(time / 60);
        int Seconds = Mathf.FloorToInt(time % 60);
        timerText.text = string.Format("{0:00}:{1:00}", Minutes, Seconds);
    }
}
