using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToStage1 : MonoBehaviour
{
    /*
    public void StageOne()
    {
        SceneManager.LoadScene("Stage1");
    }
    */
    [SerializeField]
    private SceneFadeInOut sceneFadeInOut;
    public void StageOne()
    {
        sceneFadeInOut.LoadScene("Stage1");
    }
}
