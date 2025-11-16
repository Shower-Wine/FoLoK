using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
//using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoToStage10Choice : MonoBehaviour
{
    public Image One;
    public Image Two;
    public Image Three;
    public Image Four;
    public Image Five;
    public Image Six;
    public Image Seven;
    public Image Eight;
    public Image Nine;
    public Image Ten;

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
            sceneFadeInOut.LoadScene("EndScene");
            Debug.Log("Right");
        }
        else
        {
            sceneFadeInOut.LoadScene("Stage10Fail");
            Debug.Log("Wrong");
        }
    }

    void RandomCircles()
    {
        randomNumber = Random.Range(1, 10);

        switch (randomNumber)
        {
            case 1:
                Debug.Log("One");
                break;
            case 2:
                Debug.Log("Two");
                break;
            case 3:
                Debug.Log("Three");
                break;
            case 4:
                Debug.Log("Four");
                break;
            case 5:
                Debug.Log("Five");
                break;
            case 6:
                Debug.Log("Six");
                break;
            case 7:
                Debug.Log("Seven");
                break;
            case 8:
                Debug.Log("Eight");
                break;
            case 9:
                Debug.Log("Nine");
                break;
            case 10:
                Debug.Log("Ten");
                break;
        }
    }
}
