using UnityEngine;

public class FireKiller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Debug log to check if the script is running
        Debug.Log("FireKiller script attached and running.");
    }

    // Update is called once per frame
    void Update()
    {
        // You can add any continuous checks or logic here if needed
    }

    // OnTriggerEnter is called when the Collider 'other' enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        // Check if the collided object has the tag "Fire"
        if (other.gameObject.CompareTag("fire"))
        {
            // Debug log to indicate a fire object has been detected
            Debug.Log("Fire detected and being extinguished: " + other.gameObject.name);

            // Remove or disable the fire game object
            // You can also add custom logic here to handle the fire extinguishing effect
            Destroy(other.gameObject);

            // Debug log to confirm the fire object has been removed
            Debug.Log("Fire extinguished: " + other.gameObject.name);
        }
        else
        {
            // Debug log if the object is not tagged as "Fire"
            Debug.Log("Collided with a non-fire object: " + other.gameObject.name);
        }
    }
}
