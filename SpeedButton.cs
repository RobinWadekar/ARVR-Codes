using UnityEngine;
using UnityEngine.UI;

public class SpeedButton : MonoBehaviour
{
    public BallController ballController; // Reference to the BallController script
    public float speed; // Speed to set when the button is clicked

    void Start()
    {
        // Find the BallController script in the scene
        ballController = FindObjectOfType<BallController>();
    }

    // Function to be called when the button is clicked
    public void OnButtonClick()
    {
        // Set the speed of the ball using the BallController script
        ballController.KickBall(speed);
    }
}
