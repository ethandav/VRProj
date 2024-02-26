using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioTrigger : MonoBehaviour
{
    public AudioSource audioSource;

    public void Trigger()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }

    public void Stop()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }
}
