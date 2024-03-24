using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding GameObject has the tag "Player".
        if (collision.gameObject.CompareTag("Player"))
        {
            // Perform actions to end the game by setting the time to zero.
            Debug.Log("Game over!"); // Display a message in the console.
            // Set the time to zero directly
            Time.timeScale = 0f;
            // You might want to add additional logic here to handle other game-ending actions
            // such as displaying a game over screen, freezing player controls, etc.
        }
    }
}
