using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

// 영상에서의 Scene Controller 속의 SceneController 스크립트

public class SceneController : MonoBehaviour
{
    [SerializeField]
    private float sceneFadeDuration; // sceneFadeDuration 변수 지정

    private FadeInOut5 sceneFade;

    private void Awake()
    {
        sceneFade = GetComponentInChildren<FadeInOut5>();
    }

    private IEnumerator Start()
    {
        yield return sceneFade.FadeInCoroutine(sceneFadeDuration);
    }

    public void LoadScene(string sceneName)
    {
        StartCoroutine(LoadSceneCoroutine(sceneName));
    }

    private IEnumerator LoadSceneCoroutine(string sceneName)
    {
        yield return sceneFade.FadeOutCoroutine(sceneFadeDuration);
        yield return SceneManager.LoadSceneAsync(sceneName);
    }
}
