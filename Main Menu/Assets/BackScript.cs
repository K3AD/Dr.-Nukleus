using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackScript : MonoBehaviour {

    public void Back () {
        string sceneName = PlayerPrefs.GetString("lastLoadedScene");
        SceneManager.LoadScene(sceneName);
    }
}
