using UnityEngine;

public class ToggleParticleSystem : MonoBehaviour
{
    // Reference to the Particle System GameObject
    public GameObject particleSystemObject;

    // Start is called before the first frame update
    void Start()
    {
        // Ensure the Particle System is initially turned off
        if (particleSystemObject != null)
        {
            particleSystemObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Check for mouse click
        if (Input.GetMouseButtonDown(0))
        {
            // Toggle Particle System visibility
            if (particleSystemObject != null)
            {
                // Invert the active state of the Particle System
                particleSystemObject.SetActive(!particleSystemObject.activeSelf);
            }
        }
    }
}
