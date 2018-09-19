using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public float autoLoadNextLevelAfter;

    private void Start()
    {
        if (autoLoadNextLevelAfter == 0) {
            Debug.Log("Auto Load Disabled");
        }
        else {
            Invoke("LoadNextLevel", autoLoadNextLevelAfter);
        }
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
