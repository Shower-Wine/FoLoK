using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class GoToStage2 : MonoBehaviour

{
    [SerializeField]
    private SceneFadeInOut sceneFadeInOut;
    public Image sceneFadePanel;

    private void Start()
    {
        //Color sceneFadePanel = GetComponent<Image>().color;
        //sceneFadePanel.a = 0f;
        //GetComponent<Image>().color = sceneFadePanel;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && sceneFadePanel.color.a == 0)
        // 마우스 왼쪽 버튼 누름 && Panel의 알파값 == 0
        {
            sceneFadeInOut.LoadScene("Stage2");
        }
    }
}
