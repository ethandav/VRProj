using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioOnLook : MonoBehaviour
{
    public AudioSource audioSource;
    public Transform playerCamera;
    public float maxDistance = 10f;
    public Collider GarbageManCollider;

    private void Update()
    {
        RaycastHit hit;
        Vector3 direction = playerCamera.forward;
        if (Physics.Raycast(playerCamera.position, direction, out hit, maxDistance))
        {
            if (hit.collider == GarbageManCollider && !audioSource.isPlaying)
            {
                GarbageManCollider.enabled = false;
                audioSource.Play();
            }
        }
    }
}

