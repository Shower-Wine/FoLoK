using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToStage2Description : MonoBehaviour
{
    [SerializeField]
    private SceneFadeInOut sceneFadeInOut;
    public void Description()
    {
        sceneFadeInOut.LoadScene("Stage2Description");
    }
}
