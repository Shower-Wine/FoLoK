using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToStage2 : MonoBehaviour
{
    [SerializeField]
    private SceneFadeInOut sceneFadeInOut;
    public void Confirm()
    {
        sceneFadeInOut.LoadScene("Stage2");
    }
}
