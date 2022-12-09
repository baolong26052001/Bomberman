using System.Security;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{

    public GameObject[] players;

    public GameObject gameOver;
    public TMP_Text playerWon;
    public AudioSource music;
    
    public void CheckWinState()
    {
        int aliveCount = 0;


        foreach (GameObject player in players)
        {
            if (player.activeSelf)
            {
                aliveCount++;
                gameOver.SetActive(true);
                music.Stop();
                playerWon.text = player.name + " won";
                
            }
        }
        if (aliveCount <= 1)
        {
            Invoke(nameof(NewRound), 1f);
        }

        
    }
    private void NewRound()
    {
        //SceneManager.LoadScene("GameOverScreen");
    }
    public void RestartButton()
    {
        SceneManager.LoadScene("SelectMap");
    }
    public void ExitButton()
    {
        SceneManager.LoadScene("Menu");
    }
    public void BackButton()
    {
        SceneManager.LoadScene("SelectMap");
    }
}
