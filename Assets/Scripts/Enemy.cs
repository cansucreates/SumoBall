using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5f; // Speed of the enemy
    private GameObject player; // Reference to the player object
    private Rigidbody enemyRb; // Reference to the enemy's Rigidbody component

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>(); // Get the Rigidbody component attached to this GameObject
        player = GameObject.Find("Player"); // Find the player GameObject in the scene
    }

    // Update is called once per frame
    void Update()
    {
        // Normalize direction vector to ensure constant speed regardless of distance to player
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed);
    }
}
