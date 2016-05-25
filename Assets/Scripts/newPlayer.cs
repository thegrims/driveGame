using UnityEngine;
using System.Collections;

public class newPlayer : MonoBehaviour {
    public float speed;
    private Rigidbody rb;
    int carPos = 0;
    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();

    }
	
	// Update is called once per frame
	void Update ()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        /*Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);*/
        if (Input.GetKeyDown("right"))
        {
            for(int i=0; i<10; i++)
            {
                rb.position += Vector3.right*i/10;
            }
            
        }
        if (Input.GetKeyDown("left"))
        {

            rb.position += Vector3.left * 3F;
        }
    }
    void FixedUpdate()
    {
        //updates after every physics movement
        
        
    }
}
