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
    private bool winGame = false;

    public GameObject gameOver;
    public TMP_Text playerWon;
    public AudioSource music;
    public TMP_Text timeWatch;

<<<<<<< HEAD
    private int duration = 20;
=======
    private int duration = 180;
>>>>>>> ca2b836ba2f4f4c5e1091f82b3c5be91c565d981
    private int remainingDuration;
    

    private void Start()
    {

        Being(duration);
    }

    private void Being(int second)
    {
        remainingDuration = second;
        StartCoroutine(UpdateTime());
    }
    public void CheckWinState()
    {
        //int aliveCount = 0;
        
        foreach (GameObject player in players)
        {
            if (player.activeSelf)
            {
                winGame = true;
                playerWon.text = player.name + " won";
                music.Stop();
                gameOver.SetActive(true);
                
            }
        }
        /*if (aliveCount <= 1)
        {
            //Invoke(nameof(NewRound), 1f);
        }*/
    }
    
    private IEnumerator UpdateTime()
    {
        while (remainingDuration >= 0 && winGame == false)
        {
            Debug.Log("Timer: " + remainingDuration / 60 + ": " + remainingDuration % 60);
            timeWatch.text =   remainingDuration / 60 + " : " + remainingDuration % 60;
            remainingDuration--;
            yield return new WaitForSeconds(1f);
        }
        yield return null;
        if (remainingDuration <= 0)
        {
            Time.timeScale = 0f;
            music.Stop();
            gameOver.SetActive(true);
        }
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
