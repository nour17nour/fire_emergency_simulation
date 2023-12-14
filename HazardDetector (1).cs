using UnityEngine;

public class HazardDetector : MonoBehaviour
{
    // Indicates whether this is a correct hazard
    public bool isCorrectHazard;

    public GameObject AudioToPlay;

    // The specific message for this hazard if it's correct
    public string correctHazardMessage;

    // Reference to the HazardManager
    private HazardManager hazardManager;

    void Start()
    {
        // Find the HazardManager in the scene
        hazardManager = FindObjectOfType<HazardManager>();

    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider belongs to the player or the player's VR controller
        if (other.CompareTag("Player"))
        {
            // Notify the HazardManager about the interaction
            if (isCorrectHazard)
            {
                hazardManager.CorrectHazardSelected(correctHazardMessage);
                AudioToPlay.SetActive(true);
            }
            else
            {
                hazardManager.WrongHazardSelected();
            }
        }
    }
}