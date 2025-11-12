using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectMenu : MonoBehaviour
{
    public GameObject levelSelectMenuUI;


    public void Back()
    {
        levelSelectMenuUI.SetActive(false);
    }

    public void openLevelSelectMenu()
    {
        levelSelectMenuUI.SetActive(true);
    }
    public void Onlevel1()
    {
        SceneManager.LoadScene(1);
    }
    public void Onlevel2()
    {
        SceneManager.LoadScene(2);
    }
    public void Onlevel3()
    {
        SceneManager.LoadScene(3);
    }
    public void Onlevel4()
    {
        SceneManager.LoadScene(4);
    }
}
