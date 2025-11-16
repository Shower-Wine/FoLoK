using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoToTestScene2 : MonoBehaviour
{
    [SerializeField]
    private SceneController SceneController;
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 마우스 왼쪽 버튼 누름
        {
            SceneController.LoadScene("TestScene2");
        }
    }
}
