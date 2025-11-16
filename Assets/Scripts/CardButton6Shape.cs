using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CardButton6Shape : MonoBehaviour
{
    public float AlphaThreshold = 0.1f;
    void Start()
    {
        this.GetComponent<Image>().alphaHitTestMinimumThreshold = AlphaThreshold;
    }
}
