using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Timers;
using UnityEngine.EventSystems;

public class PanelFadeInOut : MonoBehaviour
{
    private Image sceneFadePanel; // 원래 private

    private void Awake() // 스크립트 실행 시 최초 1회 실행
    {
        sceneFadePanel = GetComponent<Image>();
        // sceneFadePanel 이름으로 Image 컴포넌트 가져오기
    }

    public IEnumerator FadeInCoroutine(float duration) // FadeIn 코루틴
    {
        Color startColor = new Color(sceneFadePanel.color.r, sceneFadePanel.color.g, sceneFadePanel.color.b, 1);
        Color targetColor = new Color(sceneFadePanel.color.r, sceneFadePanel.color.g, sceneFadePanel.color.b, 0);
        // Color 변수 = new Color(sceneFadePanel의 r, g, b, alpha);

        yield return FadeCoroutine(startColor, targetColor, duration);
        // yield return startCoroutine(string); : 다른 코루틴이 끝날 때까지 대기

        gameObject.SetActive(false); // 게임오브젝트 비활성화
    }

    public IEnumerator FadeOutCoroutine(float duration) // FadeOut 코루틴
    {
        Color startColor = new Color(sceneFadePanel.color.r, sceneFadePanel.color.g, sceneFadePanel.color.b, 0);
        Color targetColor = new Color(sceneFadePanel.color.r, sceneFadePanel.color.g, sceneFadePanel.color.b, 1);

        gameObject.SetActive(true); // 게임오브젝트 활성화

        yield return FadeCoroutine(startColor, targetColor, duration);
    }

    private IEnumerator FadeCoroutine(Color startColor, Color targetColor, float duration) // Fade 코루틴
    {
        float elapsedTime = 0; // 경과 시간
        float elapsedPercentage = 0; // 경과 퍼센트

        while (elapsedPercentage < 1) // 경과 퍼센트가 1보다 작다면 반복
        {
            elapsedPercentage = elapsedTime / duration; // 경과 퍼센트 = 경과 시간 / 기간
            sceneFadePanel.color = Color.Lerp(startColor, targetColor, elapsedPercentage);
            // 경과 퍼센트가 0이면 startColor 반환, 1이면 targetColor 반환

            yield return null; // 다음 프레임까지 대기(코드의 제어권을 잠시 양보했다가 돌려받은 후 아래 코드를 계속 진행)
            elapsedTime += Time.deltaTime; // 경과 시간 = 경과 시간 + Time.deltaTime
        }
    }
/*
    public void StartButton()
    {
        StartCoroutine("FadeOutCorutine");
    }
    */
}
