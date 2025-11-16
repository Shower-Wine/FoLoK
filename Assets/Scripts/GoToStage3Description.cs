using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToStage3Description : MonoBehaviour
{
    [SerializeField]
    private SceneFadeInOut sceneFadeInOut;
    public void Description()
    {
        sceneFadeInOut.LoadScene("Stage3Description");
    }
}
