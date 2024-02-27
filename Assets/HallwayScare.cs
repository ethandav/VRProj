using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallwayScare : MonoBehaviour
{
    public FlickerLight[] flickerLights;
    public PlayAudioTrigger audioTrigger;

    private Collider trigger;

    private void Start()
    {
        trigger = GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            foreach (FlickerLight flickerLight in flickerLights)
            {
                flickerLight.StartFlickering();
            }
            audioTrigger.Trigger();
            trigger.enabled = false;
        }
    }

}
