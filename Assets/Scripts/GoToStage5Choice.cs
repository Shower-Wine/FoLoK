using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
//using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoToStage5Choice : MonoBehaviour
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

    [SerializeField]
    private SceneFadeInOut sceneFadeInOut;
    public void OnButtonClick(int buttonNumber)
    {
        Debug.Log(randomNumber);
        if (buttonNumber == randomNumber)
        {
            sceneFadeInOut.LoadScene("Stage5Pass");
            Debug.Log("Right");
        }
        else
        {
            SceneManager.LoadScene("Stage5Fail");
            Debug.Log("Wrong");
        }
    }

    void RandomCircles()
    {
        randomNumber = Random.Range(1, 6);

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
        }
    }
}
