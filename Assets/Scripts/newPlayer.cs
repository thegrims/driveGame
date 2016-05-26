using UnityEngine;
using System.Collections;

public class newPlayer : MonoBehaviour {
    public float speed;
    private Rigidbody rb;
    int carPos = 0;
    public Vector3 targetPosition = new Vector3(0f,0f,1f);
    float m_fSpeed = 200f;
    bool left = false;
    bool right = false;
    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (m_fSpeed <= 1)//&&((rb.position.x==0f) || (rb.position.x == 6.6f) || (rb.position.x == -6.6f)))
        {
            right = false;
            left = false;
            m_fSpeed = 0;
            //rb.position.z = 0;
            if((-2<rb.position.x)&&(2 > rb.position.x))
            {
                transform.Translate(Vector3.right * rb.position.x*-1);
            }

            //transform.Translate(Vector3.right * );
        }

        if ((right==true)&&(rb.position.x<20))
        {
            Debug.Log(rb.position.x);
            m_fSpeed = m_fSpeed / 1.5f;
            transform.Translate(Vector3.right * m_fSpeed * Time.deltaTime);
        }
        if ((left == true)&& (rb.position.x <20))
        {

            Debug.Log(rb.position.x);
            m_fSpeed = m_fSpeed / 1.5f;
            transform.Translate(Vector3.left * m_fSpeed * Time.deltaTime);
        }
        //if (rb.position.z>=10)
        //{
        //    right = false;
        //}
        //float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");

        /*Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);*/
        if (Input.GetKeyDown("right"))
        {
            right = true;
            m_fSpeed = 200f;
        }
        if (Input.GetKeyDown("left"))
        {
            left = true;
            m_fSpeed = 200f;
            //rb.position += Vector3.left * 3F;
            //Debug.Log(rb.position);
        }
    }
    void FixedUpdate()
    {
        //updates after every physics movement
        
        
    }
}
