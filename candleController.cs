using UnityEngine;

public class CandleController : MonoBehaviour
{
    public GameObject flameGameObject;

    void Start()
    {
        // Ensure the flame is initially unlit
        if (flameGameObject != null)
        {
            flameGameObject.SetActive(false);
        }
    }

    void Update()
    {
        // Check for mouse click
        if (Input.GetMouseButtonDown(0))
        {
            // Toggle flame visibility
            if (flameGameObject != null)
            {
                flameGameObject.SetActive(!flameGameObject.activeSelf);
            }
        }
    }
}
