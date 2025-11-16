using UnityEngine;
using System;
using System.Collections;

public class FadeInOut : MonoBehaviour
{
    public bool isFadeIn; // true: FadeIn, false: FadeOut
    public GameObject panel;
    private Action onCompleteCallback; // FadeIn, FoadeOut 이후 진행할 함수

    void Start()
    {
        if (!panel)
        {
            Debug.LogError("Panel 오브젝트를 찾을 수 없습니다.");
            throw new MissingComponentException();
        }

        if (isFadeIn)
        {
            panel.SetActive(true);
            StartCoroutine(CoFadeIn());
        }
        else
        {
            panel.SetActive(false);
        }
    }

    public void FadeOut()
    {
        panel.SetActive(true);
        Debug.Log("FadeCanvasController_ Fade Out 시작");
        StartCoroutine(CoFadeOut());
        Debug.Log("FadeCanvasController_ Fade Out 끝");
    }

    IEnumerator CoFadeIn()
    {
        float elapsedTime = 0f; // 누적 경과 시간
        float fadedTime = 0.5f; // 총 소요 시간

        while (elapsedTime <= fadedTime)
        {
            panel.GetComponent<CanvasRenderer>().SetAlpha(Mathf.Lerp(1f, 0f, elapsedTime / fadedTime));

            elapsedTime += Time.deltaTime;
            Debug.Log("Fade In 중...");
            yield return null;
        }
        Debug.Log("Fade In 끝");
        panel.SetActive(false);
        onCompleteCallback?.Invoke();
        yield break;
    }

    IEnumerator CoFadeOut()
    {
        float elapsedTime = 0f;
        float fadedTime = 0.5f;

        while (elapsedTime <= fadedTime)
        {
            panel.GetComponent<CanvasRenderer>().SetAlpha(Mathf.Lerp(0f, 1f, elapsedTime / fadedTime));

            elapsedTime += Time.deltaTime;
            Debug.Log("Fade Out 중...");
            yield return null;
        }

        Debug.Log("Fade Out 끝");
        onCompleteCallback?.Invoke();
        yield break;
    }

    public void RegisterCallback(Action callback)
    {
        onCompleteCallback = callback;
    }
}
