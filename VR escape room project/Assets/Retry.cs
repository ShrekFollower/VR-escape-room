using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{

    public string scene;

    public void Reset()
    {
        SceneManager.LoadScene(scene);
    }
}
