using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroText : MonoBehaviour
{
    public float fadeDurationSecs = 1f; // 페이드 완료까지 걸리는 시간
    public float fadeProgress = 0f; // 시작 글자 색깔
    public float fadeStep = 0.01f; // 페이드 색깔 짙어지는 단계

    Text textFadeIn;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textFadeIn = GetComponentInParent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (fadeProgress < 1) // (fadeProgressFirst > 1) || (fadeProgressFirst < 0)
        {
            fadeStep *= 1f; // fadeStep = fadeStep * 1f
            fadeProgress += fadeStep; // fadeProgress = fadeProgress + fadeStep
        }
        textFadeIn.color = Color.Lerp(Color.black, Color.white, fadeProgress);
    }
}