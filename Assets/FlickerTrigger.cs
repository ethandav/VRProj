using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayer : MonoBehaviour
{
    public FlickerLight flickerLight;
    public GarbageMan garbageMan;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            flickerLight.DisableLight();
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
        }
    }
}
