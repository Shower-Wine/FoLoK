using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
//using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoToStage1Choice : MonoBehaviour
{
    public Image One;

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
            sceneFadeInOut.LoadScene("Stage1Pass");
            Debug.Log("Right");
        }
    }

    void RandomCircles()
    {
        randomNumber = Random.Range(1, 2);

        switch (randomNumber)
        {
            case 1:
                Debug.Log("One");
                break;
        }
    }
}
