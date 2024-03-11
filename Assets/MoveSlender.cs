using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSlender : MonoBehaviour
{
    
    public GameObject Prefab = null;
    
    public void Enable()
    {
        Prefab.SetActive(true);
    }

    public void Disable()
    {
        Prefab.SetActive(false);
    }

    public void MoveToPosition(Vector3 newPosition)
    {
        Prefab.transform.position = newPosition;
    }
}
