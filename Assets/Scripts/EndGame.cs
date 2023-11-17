using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    public Button Quitbtn;
    public Button Restartbtn;
    public void endGame()
    {
        //Application.Quit();
        Debug.Log("Quited");
        Restartbtn.interactable = false;
        SceneManager.LoadScene("Start");
    }

    public void Restartgame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void RealQuit()
    {
       
        Application.Quit();
        Restartbtn.interactable = false;
    }
}
