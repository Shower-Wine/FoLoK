using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Timers;

// 영상에서의 Scene Fade 이미지 속의 SceneFade 스크립트

public class FadeInOut5 : MonoBehaviour
{
    private Image sceneFadePanel_1; // sceneFadePanel = _sceneFadeImage

    private void Awake()
    {
        sceneFadePanel_1 = GetComponent<Image>();
    }

    public IEnumerator FadeInCoroutine(float duration)
    {
        Color startColor = new Color(sceneFadePanel_1.color.r, sceneFadePanel_1.color.g, sceneFadePanel_1.color.b, 1);
        Color targetColor = new Color(sceneFadePanel_1.color.r, sceneFadePanel_1.color.g, sceneFadePanel_1.color.b, 0);

        yield return FadeCoroutine(startColor, targetColor, duration);

        gameObject.SetActive(false);
    }

    public IEnumerator FadeOutCoroutine(float duration)
    {
        Color startColor = new Color(sceneFadePanel_1.color.r, sceneFadePanel_1.color.g, sceneFadePanel_1.color.b, 0);
        Color targetColor = new Color(sceneFadePanel_1.color.r, sceneFadePanel_1.color.g, sceneFadePanel_1!.color.b, 1);

        gameObject.SetActive(true);

        yield return FadeCoroutine(startColor, targetColor, duration);
    }

    private IEnumerator FadeCoroutine(Color startColor, Color targetColor, float duration)
    {
        float elapsedTime = 0;
        float elapsedPercentage = 0;

        while (elapsedPercentage < 1)
        {
            elapsedPercentage = elapsedTime / duration;
            sceneFadePanel_1.color = Color.Lerp(startColor, targetColor, elapsedPercentage);

            yield return null;
            elapsedTime += Time.deltaTime;
        }
    }
}
