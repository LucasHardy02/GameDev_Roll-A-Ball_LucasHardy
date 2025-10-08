using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.ProBuilder.MeshOperations;
public class PlayerController : MonoBehaviour
{
    public float speed = 0;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;
    public bool IsGrounded;
    public float Height;
    public GameObject player;

    private Rigidbody rb;
    private float movementX;
    private float movementY;
    private int count;

    public float hop;
   
  
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        Height = 1.1f;
        SetCountText();
        winTextObject.SetActive(false);
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if(count >= 13)
        {
            winTextObject.SetActive(true);

            Destroy(GameObject.FindGameObjectWithTag("Enemy"));
        }
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);

        if (Physics.Raycast(transform.position, Vector3.down, Height))
        {
            IsGrounded = true;
            Debug.Log("Grounded");
        }
        else
        {
            IsGrounded = false;
            Debug.Log("Not Grounded!");
        }   
    }
        

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            player.gameObject.SetActive(false);

            winTextObject.gameObject.SetActive(true);
            winTextObject.GetComponent<TextMeshProUGUI>().text = "You Lose!";
        }
        else if (collision.gameObject.CompareTag("Water"))
        {
            if (count >= 13)
            {

            }
            else
            {
                player.gameObject.SetActive(false);


                winTextObject.gameObject.SetActive(true);
                winTextObject.GetComponent<TextMeshProUGUI>().text = "You Lose!";
            }
                

            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;

            SetCountText();
        }
    }

    void OnJump(InputValue jumpValue)
    {
        
        if (IsGrounded == true)
        {
            rb.AddForce(Vector3.up * hop, ForceMode.Impulse);
        }
        else if (IsGrounded == false)
        {
            
        }
        
    }

   

}
