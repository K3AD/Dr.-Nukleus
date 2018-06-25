 ﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

  public void PlayGame() {
    SceneManager.LoadScene("Story Kapitel 1");
  }

    public void PlayMinigameOne () {
        SceneManager.LoadScene("Spiel 1");
    }  
}
