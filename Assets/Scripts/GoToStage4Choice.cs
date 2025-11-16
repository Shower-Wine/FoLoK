using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
//using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoToStage4Choice : MonoBehaviour
{
    public Image One;
    public Image Two;
    public Image Three;
    public Image Four;

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
            sceneFadeInOut.LoadScene("Stage4Pass");
            Debug.Log("Right");
        }
        else
        {
            sceneFadeInOut.LoadScene("Stage4Fail");
            Debug.Log("Wrong");
        }
    }

    void RandomCircles()
    {
        randomNumber = Random.Range(1, 5);

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
        }
    }
}
