using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsMenu : MonoBehaviour
{
    public GameObject CreditMenuUI;


    public void Back()
    {
        CreditMenuUI.SetActive(false);
    }

    public void openCreditMenu()
    {
        CreditMenuUI.SetActive(true);
    }
}
