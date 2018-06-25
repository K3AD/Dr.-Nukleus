using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LosButtonScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public GameObject myObject;
    public GameObject myObject2;

    //Detect if the Cursor starts to pass over the GameObject
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        //Output to console the GameObject's name and the following message
        myObject.SetActive(true);
        myObject2.SetActive(true);
    }

    //Detect when Cursor leaves the GameObject
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        //Output the following message with the GameObject's name
        myObject.SetActive(false);
        myObject2.SetActive(false);
    }

    public void PlayMinigameOne () {
        SceneManager.LoadScene("Spiel 1");
    }  

    public void PlayMinigameTwo () 
    {
        SceneManager.LoadScene("Spiel 2");
    }
}
