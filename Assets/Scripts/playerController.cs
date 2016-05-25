using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour {
    public float speed;
    public float jumpSpeed;
    private int pickupCount = 0;
    private Rigidbody rb;
    bool jumping = false;
    public Text countText;
    int platform = 0;
    //public static bool winTrigger = false;

    void Start()
    {
        if (Application.platform == RuntimePlatform.WindowsPlayer)
        {
            platform = 1;
        }
        if (Application.platform == RuntimePlatform.Android)
        {
            platform = 2;
        }
        //countText.GetComponent<CanvasRenderer>().SetAlpha(0.5f);
        SetCountText();
        rb = GetComponent<Rigidbody>();
    }
    void Update ()
    {
        //updates after every frame of movement
        if (Input.GetKeyDown("space") && jumping == false)
        {
            {
                rb.AddForce(new Vector3(0, jumpSpeed, 0), ForceMode.Impulse);
            }
            jumping = true;
        }
        
    }
    void FixedUpdate ()
    {
        //updates after every physics movement
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement*speed);
        

    }
    void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.CompareTag("pick up"))
        {
        //    pickupCount++;
        //    SetCountText();
        //    other.gameObject.SetActive(false);
        }
    }
    void OnCollisionStay()
    {
        jumping = false;
    }
    /*void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            //Debug.Log("test1");
            if (Input.GetKeyDown("space"))
            {
                rb.AddForce(new Vector3(0, jumpSpeed, 0), ForceMode.Impulse);
            }
            jumping = false;
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            //Debug.Log("test1");
            /*if (Input.GetKeyDown("space"))
            {
                rb.AddForce(new Vector3(0, jumpSpeed, 0), ForceMode.Impulse);
            }
            jumping = true;
        }
    }*/

    void SetCountText()
    {
        countText.text = "SCORE: " + pickupCount.ToString();
        if (pickupCount >= 4)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            //winText.text = "You Win!";
        }
    }
}


    
