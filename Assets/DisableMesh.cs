using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableMesh : MonoBehaviour
{
    public bool disableAfterActivation = false;
    public GameObject target;

    private void OnTriggerEnter(Collider other)
    {
            Debug.Log("Test");
        if (other.CompareTag("TargetMesh"))
        {
            target.SetActive(false);
            if(disableAfterActivation)
            {
                GetComponent<Collider>().enabled = false;
            }
        }
    }
}
