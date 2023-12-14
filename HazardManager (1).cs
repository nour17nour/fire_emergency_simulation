using UnityEngine;
using TMPro;

public class HazardManager : MonoBehaviour
{
    // Reference to the TextMeshPro UI component
    public TextMeshProUGUI messageText;

    // Total number of correct hazards in the scene
    private int totalCorrectHazards = 3;

    // Number of correctly identified hazards
    private int identifiedCorrectHazards = 0;

    // Call this when a correct hazard is selected
    public void CorrectHazardSelected(string message)
    {
        identifiedCorrectHazards++;
        messageText.text = message;

        // Check if all correct hazards have been identified
        if (identifiedCorrectHazards == totalCorrectHazards)
        {
            messageText.text = "All fire hazards are cleared!";
        }
    }

    // Call this when a wrong hazard is selected
    public void WrongHazardSelected()
    {
        messageText.text = "Sorry, wrong object.";
    }
}