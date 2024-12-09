using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catchable : MonoBehaviour
{
    public int scoreValue = 10; // Points for catching this object
    public bool isBomb = false; // Is this object a bomb?


    void OnTriggerEnter(Collider other)
    {

        UnityEngine.Debug.Log("Bomb caught! Game over.");

        if (other.CompareTag("Player")) // Basket tag should be "Player"
        {
            UnityEngine.Debug.Log("Bomb caught! Game over.");

            if (isBomb)
            {
                //  Debug.Log("Bomb caught! Game over.");
                // Implement Game Over logic here
                UnityEngine.Debug.Log("Bomb caught! Game over.");
            }
            else
            {
                //Debug.Log("Object caught! +" + scoreValue + " points.");
                GameManager.instance.AddScore(scoreValue); // Update score
                UnityEngine.Debug.Log("Bomb caught! Game over.");

            }
            Destroy(gameObject); // Remove the object
        }
    }
}


