using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.ProBuilder.MeshOperations;
using UnityEngine.SceneManagement;

public class NextStageMenu : MonoBehaviour
{
    private bool isPaused = false;
    public GameObject pauseMenuUI;
    private int currentScene;

    void Update()
    {

    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void NextStage()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        
        SceneManager.LoadScene(nextSceneIndex);
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
