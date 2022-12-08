using System.Security;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] players;

    public void CheckWinState()
    {
        int aliveCount = 0;

        foreach (GameObject player in players)
        {
            if(player.activeSelf)
            {
                aliveCount++;
            }
        }
        if(aliveCount <= 1)
        {
            Invoke(nameof(NewRound),1f);
        }
        
        


    }
    private void NewRound()
    {
        SceneManager.LoadScene("GameOverScreen");
    }
}
