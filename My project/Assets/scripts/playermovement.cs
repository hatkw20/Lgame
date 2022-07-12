
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    // we use FixedUpdate as it make things run smoother
    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardForce * Time.deltaTime); //Add a forwardforce
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
           if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        if(rb.position.y < -10f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
