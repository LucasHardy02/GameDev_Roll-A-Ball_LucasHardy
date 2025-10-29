using Unity.VisualScripting;
using UnityEngine;

public class KeyandDoorScript : MonoBehaviour
{
    public Animator DoorAnim;
    static bool HasKey = false;

    private void Start()
    {
        DoorAnim.enabled = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Key"))
        {
            other.gameObject.SetActive(false);
            HasKey = true;
        }
        if (HasKey == true && other.gameObject.CompareTag("Door"))
        {
            DoorAnim.enabled = true;
            other.gameObject.SetActive(false);
            HasKey = false;
        }
    }
}
