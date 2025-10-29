using UnityEngine;

public class KeyRotator : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(0, 45, 0) * Time.deltaTime);
    }
}
