using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionAmbience : MonoBehaviour
{
    public PlayAudioTrigger audioTrigger;
    private int InColliderCounter = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            InColliderCounter++;
            audioTrigger.Trigger();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            InColliderCounter--;
            if(InColliderCounter == 0)
            {
                audioTrigger.Stop();
            }
        }
    }
}
