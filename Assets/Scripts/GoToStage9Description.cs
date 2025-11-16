using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToStage9Description : MonoBehaviour
{
    [SerializeField]
    private SceneFadeInOut sceneFadeInOut;
    public void Description()
    {
        sceneFadeInOut.LoadScene("Stage9Description");
    }
}
