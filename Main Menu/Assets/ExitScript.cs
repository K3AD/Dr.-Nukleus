using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitScript : MonoBehaviour
{

    public void Exit ()
    {
        PlayerPrefs.SetString("lastLoadedScene", SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("QuitMenu");

    }
}
