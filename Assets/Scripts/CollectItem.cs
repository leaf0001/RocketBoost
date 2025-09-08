using UnityEngine;

public class CollectItem : MonoBehaviour
{
    //refernece the variable GhostCount from the script GhostScoreManager
    GhostScoreManager GhostScoreManager;

    private void Start()
    {
        GhostScoreManager = FindAnyObjectByType<GhostScoreManager>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnTriggerEnter(Collider other) // For 3D colliders
    {
        // Check if the triggered object has the specific tag
        if (other.gameObject.tag == "Player")
        {
            // Run your desired code here
            Debug.Log("Triggered DestroyableObject!");
            GhostScoreManager.increaseScore(1);
            // Destroy the triggered object
            Destroy(gameObject);
        }
    }

}
