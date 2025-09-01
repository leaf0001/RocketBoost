using UnityEngine;

public class CollectItem : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter(Collider other) // For 3D colliders
    {
        // Check if the triggered object has the specific tag
        if (other.CompareTag("Player"))
        {
            // Run your desired code here
            Debug.Log("Triggered DestroyableObject!");

            // Destroy the triggered object
            Destroy(other.gameObject);
        }
    }

}
