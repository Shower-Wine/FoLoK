using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

// 영상에서 Main Panel 속의 MainMenu 스크립트
public class FadePanel : MonoBehaviour
{
    [SerializeField]
    private SceneController sceneController;

    public void Play()
    {
        sceneController.LoadScene("TestScene2");
    }
}
