using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerLight : MonoBehaviour
{
    public float minIntensity = 0.0f;
    public float maxIntensity = 5.0f;
    public float flickerSpeed = 1.0f;
    public bool isFlickering = false;

    private Light lightSource;

    private void Start()
    {
        lightSource = GetComponent<Light>();
    }

    public void DisableLight()
    {
        lightSource.enabled = false;
    }

    public void EnableLight()
    {
        lightSource.enabled = true;
    }

    public void StartFlickering()
    {
        isFlickering = true;
        StartCoroutine(Flicker());
    }

    public void StopFlickering()
    {
        isFlickering = false;
        StopCoroutine(Flicker());
        lightSource.intensity = maxIntensity;
    }

    private IEnumerator Flicker()
    {
        while (isFlickering)
        {
            flickerSpeed = Random.Range(0.0f, 0.1f);
            lightSource.intensity = Random.Range(minIntensity, maxIntensity);
            yield return new WaitForSeconds(flickerSpeed);
        }
    }
}

