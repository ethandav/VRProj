using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableMesh : MonoBehaviour
{
    public bool disableAfterActivation = false;
    public GameObject target;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            target.SetActive(true);
            if(disableAfterActivation)
            {
                GetComponent<Collider>().enabled = false;
            }
        }
    }

}
