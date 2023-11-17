
using System;
using System.Net.Security;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool isGameFinished = false;
    [SerializeField] GameObject NextLevelUI;
    public void CompleteLevel()
    {
        
        NextLevelUI.SetActive(true);
    }

    public void Finished()
    {

        if (isGameFinished == false)
        {
            isGameFinished = true;
            Debug.Log("Finished All Levels!!");
            Invoke("Credit", 1.5f);

        }
    }
    public void EndGame()
    {
        if (isGameFinished == false)
        {
            isGameFinished = true;
            Debug.Log("GAME OVER!!");
            Invoke("Restart", 1.5f);
            
        }
    }

    void Restart()
    {
        SceneManager.LoadScene("EndScene");
    }

    void Credit()
    {
        SceneManager.LoadScene("CreditScene");
    }
}
