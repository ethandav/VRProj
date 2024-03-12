using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothMovement : MonoBehaviour
{
    public Transform target; // Assign the hand transform here
    public float positionSmoothTime = 0.1f; // Adjust for smoother or more immediate following
    public float rotationSmoothTime = 0.1f; // Adjust for smoother or more immediate following

    private Vector3 currentVelocity; // Used internally by SmoothDamp

    private void Update()
    {
        // Lerp position
        transform.position = Vector3.Lerp(transform.position, target.position, positionSmoothTime * Time.deltaTime);

        // Lerp rotation
        transform.rotation = Quaternion.Lerp(transform.rotation, target.rotation, rotationSmoothTime * Time.deltaTime);
    }
}
