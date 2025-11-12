using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.ProBuilder.MeshOperations;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    private bool isPaused = false;
    public GameObject DeathMenuUI;
    private int currentScene;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
           
        }

    }
    public void Died()
    {
        DeathMenuUI.SetActive(true);
    }
    
    public void MainMenu()
    {

        SceneManager.LoadScene(0);
        Time.timeScale = 1f;

    }
    public void Retry()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
