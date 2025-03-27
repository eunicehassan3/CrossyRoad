using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    public GameObject gameOverPanel;
    public void RestartGame(){
        SceneManager.LoadScene("MainGame");
        gameOverPanel.SetActive(false);
    }
}
