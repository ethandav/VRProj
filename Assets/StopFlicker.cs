using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopFlicker : MonoBehaviour
{
    public FlickerLight[] flickerLights;

    private Collider trigger;

    private void Start()
    {
        trigger = GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TargetMesh"))
        {
            foreach (FlickerLight flickerLight in flickerLights)
            {
                flickerLight.StopFlickering();
            }
            trigger.enabled = false;
        }
    }
}
