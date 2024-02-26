using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTerrainDetector : MonoBehaviour
{
    private string currentTerrainType = "Default";

    private void OnTriggerEnter(Collider other)
    {
        currentTerrainType = other.tag;
    }

    public string GetCurrentTerrainType()
    {
        return currentTerrainType;
    }
}
