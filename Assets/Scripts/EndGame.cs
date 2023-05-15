using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    [SerializeField] private GameObject gameEndPanel;
    [SerializeField] private AudioSource music;
    [SerializeField] private AudioSource endGame;
    
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            music.Stop();
            endGame.Play();
            gameEndPanel.SetActive(true);
            Debug.Log("!!!!!!!!!");
            Debug.Log(Time.time);
        }
    }
}
