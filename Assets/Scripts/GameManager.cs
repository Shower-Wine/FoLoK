using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private float timeToWaitBeforeExit; // 나가기 전까지 대기하는 시간

    [SerializeField]
    private SceneController sceneController;

    public void OnPlayerDied()
    {
        Invoke(nameof(EndGame), timeToWaitBeforeExit); // EndGame이라는 함수를 timeToWaitBeforeExit 시간 뒤에 실행
    }

    private void EndGame()
    {
        sceneController.LoadScene("TestScene");
    }
}
