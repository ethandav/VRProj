using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayer : MonoBehaviour
{
    public FlickerLight flickerLight;
    public GarbageMan garbageMan;
    public PlayAudioTrigger audioTrigger;
    public PlayAudioTrigger musicTrigger;

    private Collider trigger;

    private void Start()
    {
        trigger = GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            flickerLight.DisableLight();
            audioTrigger.Trigger();
            musicTrigger.Trigger();
            garbageMan.Disable();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            flickerLight.EnableLight();
            flickerLight.StartFlickering();
            garbageMan.MoveToPosition(new Vector3(-48.0f, 8.0f, 1.0f));
            garbageMan.Enable();
            trigger.enabled = false;
        }
    }
}
