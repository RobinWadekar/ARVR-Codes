using UnityEngine;

public class BallController : MonoBehaviour
{
    // Define variables for different speeds
    public float slowSpeed = 5f;
    public float mediumSpeed = 20f;
    public float fastSpeed = 50f;

    // Rigidbody component of the ball
    private Rigidbody rb;

    void Start()
    {
        // Get the Rigidbody component of the ball
        rb = GetComponent<Rigidbody>();

        // Disable the Rigidbody initially
        rb.isKinematic = true;
    }

    void Update()
    {
        // Check for player input to change ball speed
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            KickBall(slowSpeed);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            KickBall(mediumSpeed);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            KickBall(fastSpeed);
        }
    }

    // Function to kick the ball with specified speed
    public void KickBall(float speed)
    {
        // Enable the Rigidbody
        rb.isKinematic = false;

        // Apply force to the ball in a straight direction (along the Z-axis)
        Vector3 kickDirection = Vector3.forward; // Straight along the Z-axis
        rb.AddForce(kickDirection * speed, ForceMode.Impulse);
    }
}
