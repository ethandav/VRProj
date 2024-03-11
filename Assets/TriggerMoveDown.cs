using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMoveDown : MonoBehaviour
{
     // Reference to the prefab object
    public MoveSlender moveSlender; // Reference to the MoveDown script on the prefab

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Pass the desired position to the MoveDown script
           moveSlender.MoveToPosition(new Vector3(1.0f, -50.0f, 1.0f));
        }
    }
}
