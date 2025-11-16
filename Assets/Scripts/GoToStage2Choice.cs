using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
//using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoToStage2Choice : MonoBehaviour
{
    public Image One;
    public Image Two;

    int randomNumber = 0;

    void Start()
    {
        RandomCircles();
    }

    [SerializeField]
    private SceneFadeInOut sceneFadeInOut;
    public void OnButtonClick(int buttonNumber)
    {
        Debug.Log(randomNumber);
        if (buttonNumber == randomNumber)
        {
            sceneFadeInOut.LoadScene("Stage2Pass");
            Debug.Log("Right");
        }
        else
        {
            sceneFadeInOut.LoadScene("Stage2Fail");
            Debug.Log("Wrong");
        }
    }

    void RandomCircles()
    {
        randomNumber = Random.Range(1, 3); // int 제거함

        switch (randomNumber)
        {
            case 1:
                Debug.Log("One");
                break;
            case 2:
                Debug.Log("Two");
                break;
        }
    }
}