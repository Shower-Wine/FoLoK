using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
//using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.UI;
// TestScene 내용

public class ButtonTestEx : MonoBehaviour
{
    public Image One;
    public Image Two;
    public Image Three;
    public Image Four;
    public Image Five;

    // private float buttonTimer = 1f;

    int randomNumber = 0;

    void Start()
    {
        RandomCircles();
    }

    public void OnButtonClick(int buttonNumber)
    {
        Debug.Log(randomNumber);
        if (buttonNumber == randomNumber)
        {
            Debug.Log("Right");
        }
        else
        {
            // SceneManager.LoadScene("GameOverScreen"); 게임오버 씬 넣을 수 있음.
            Debug.Log("Wrong");
        }
    }

    void RandomCircles()
    {
        randomNumber = Random.Range(1, 6); // int 제거함

        switch (randomNumber)
        {
            case 1:
                Debug.Log("One");
                // One.GetComponent<Image>().color = new Color32(157, 240, 136, 255);
                break;
            case 2:
                Debug.Log("Two");
                // Two.GetComponent<Image>().color = new Color32(157, 240, 136, 255);
                break;
            case 3:
                Debug.Log("Three");
                // Three.GetComponent<Image>().color = new Color32(157, 240, 136, 255);
                break;
            case 4:
                Debug.Log("Four");
                // Four.GetComponent<Image>().color = new Color32(157, 240, 136, 255);
                break;
            case 5:
                Debug.Log("Five");
                // Five.GetComponent<Image>().color = new Color32(157, 240, 136, 255);
                break;
        }
    }
    /*
    void Update()
    {
        TimerCountdown();
    }
    void TimerCountdown()
    {
        buttonTimer -= Time.deltaTime;

        if (buttonTimer < 0)
        {
            TimerZero();
        }
    }
    void TimerZero()
    {
        One.GetComponent<Image>().color = new Color32(38, 38, 38, 255);
        Two.GetComponent<Image>().color = new Color32(38, 38, 38, 255);
        Three.GetComponent<Image>().color = new Color32(38, 38, 38, 255);
        Four.GetComponent<Image>().color = new Color32(38, 38, 38, 255);
        Five.GetComponent<Image>().color = new Color32(38, 38, 38, 255);
    }
    */
}
