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
        enemyRb.AddForce((player.transform.position - transform.position) * speed * Time.deltaTime); // Move the enemy towards the player
    }
}
