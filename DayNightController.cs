using UnityEngine;
using UnityEngine.UI;

public class DayNightController : MonoBehaviour
{
    public Image buttonImage; // Reference to the Image component of the button
    public Sprite dayImage; // Reference to the day image
    public Sprite nightImage; // Reference to the night image
    private bool isDay = true; // Flag to track if it's currently day or night

    // This method is called when the button is clicked
    public void ToggleDayNight()
    {
        // Check if it's currently day or night and toggle accordingly
        if (isDay)
        {
            // Change the button image to the night image
            buttonImage.sprite = nightImage;
        }
        else
        {
            // Change the button image to the day image
            buttonImage.sprite = dayImage;
        }
        
        // Toggle the flag
        isDay = !isDay;
    }
}
