using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;

public class ButtonsLogic : MonoBehaviour, IPointerClickHandler
{


    private void Update()
    {
       
    }



    public void GameStart()
    {
        SceneManager.LoadScene("Scenes/GameScene");
    }

    public void GameMenu()
    {
        SceneManager.LoadScene("Scenes/MainMenuScene");
    }
    
    public void GameRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
    
    public void GameQuit()
    {
        Application.Quit();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Click");
    }
}
