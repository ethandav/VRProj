using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionAmbience : MonoBehaviour
{
    public PlayAudioTrigger audioTrigger;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audioTrigger.Trigger();
        }
    }
}
