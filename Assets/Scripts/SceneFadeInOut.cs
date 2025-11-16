using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class SceneFadeInOut : MonoBehaviour
{
    [SerializeField]
    private float sceneFadeTime; // Scene이 페이드되는 시간

    private PanelFadeInOut PanelFadeInOut;

    private void Awake() // 스크립트 실행 시 최초 1회 실행
    {
        PanelFadeInOut = GetComponentInChildren<PanelFadeInOut>();
        // PanelFadeInOut 이름으로 Panel의 하위 컴포넌트(스크립트) 가져오기.
    }

    private IEnumerator Start() // Scene 시작할 때 FadeIn
    {
        yield return PanelFadeInOut.FadeInCoroutine(sceneFadeTime);
    }

    public void LoadScene(string sceneName)
    {
        StartCoroutine(LoadSceneCoroutine(sceneName));
    }

    private IEnumerator LoadSceneCoroutine(string sceneName) // Scene 끝날 때 FadeOut
    {
        yield return PanelFadeInOut.FadeOutCoroutine(sceneFadeTime);
        yield return SceneManager.LoadSceneAsync(sceneName);
    }
}
