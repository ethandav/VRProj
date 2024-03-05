using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelStartTextScreen : MonoBehaviour
{
    public string text;
    public float fadeDuration = 2.0f;
    public float displayTime = 2.0f;

    private CanvasGroup canvasGroup;
    private float timer;
    private TextMeshProUGUI textMeshPro;

    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        timer = displayTime;

        textMeshPro = GetComponentInChildren<TextMeshProUGUI>();
        if (textMeshPro != null)
        {
            textMeshPro.text = text;
        }
    }

    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                StartCoroutine(FadeOut());
            }
        }
    }

    IEnumerator FadeOut()
    {
        float startAlpha = canvasGroup.alpha;
        for (float t = 0; t < 1; t += Time.deltaTime / fadeDuration)
        {
            canvasGroup.alpha = Mathf.Lerp(startAlpha, 0, t);
            yield return null;
        }

        canvasGroup.alpha = 0;
    }
}
