using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyX : MonoBehaviour
{
    public float baseSpeed = 0; // Base speed of the enemy
    public float speed;
    private Rigidbody enemyRb;
    private GameObject playerGoal;
    public int waveNumber = 1;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        playerGoal = GameObject.Find("Player Goal"); // Find the player goal in the scene

        // Set enemy speed based on wave number
        speed = baseSpeed + (0.1f * waveNumber);
    }

    // Update is called once per frame
    void Update()
    {
        // Set enemy direction towards player goal and move there
        Vector3 lookDirection = (playerGoal.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed);
    }

    private void OnCollisionEnter(Collision other)
    {
        // If enemy collides with either goal, destroy it
        if (other.gameObject.name == "Enemy Goal")
        {
            Destroy(gameObject);
        }
        else if (other.gameObject.name == "Player Goal")
        {
            Destroy(gameObject);
        }
    }
}
