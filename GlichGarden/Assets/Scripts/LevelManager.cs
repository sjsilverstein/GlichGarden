using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public float autoLoadNextLevelAfter;

    private void Start()
    {
        Invoke("LoadNextLevel", autoLoadNextLevelAfter);
    }

    public void LoadLevel(string name) {
        Debug.Log("Load New Level: " + name);
        Application.LoadLevel(name);
    }
    public void QuitRequest() {
        Debug.Log("Quit Request Recieved");
        Application.Quit();
    }
    public void LoadNextLevel() {
        Application.LoadLevel(Application.loadedLevel + 1);
    }
}
