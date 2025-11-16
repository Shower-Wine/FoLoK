using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FadeInOut3 : MonoBehaviour
{
    public Image fadeImage;
    public void init()
    {
        StartCoroutine(WaitForDisplayLogo());
    }

    private IEnumerator WaitForDisplayLogo()
    {
        Debug.Log("complete");

        Color startColor = fadeImage.color;
        for (int i = 0; i < 100; i++)
        {
            startColor.a = startColor.a + 0.01f;
            fadeImage.color = startColor;
            yield return new WaitForSeconds(0.01f);
        }
    }
}
