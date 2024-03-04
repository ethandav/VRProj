using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateTrigger : MonoBehaviour
{
    public bool disableAfterActivation = false;
    public Collider targetTrigger;
    public string ActivatorTag = "";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(ActivatorTag))
        {
            targetTrigger.GetComponent<Collider>().enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(ActivatorTag))
        {
            if(disableAfterActivation)
            {
                GetComponent<Collider>().enabled = false;
            }
        }
    }
}
