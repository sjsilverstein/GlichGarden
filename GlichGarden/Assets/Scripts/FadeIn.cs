using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour {

    public float fadeInTimeInSeconds;
    private Image fadePanel;
    private Color currentColor = Color.black;

    private void Start()
    {
        fadePanel = GetComponent<Image>();
    }
    private void Update()
    {
        if (Time.timeSinceLevelLoad < fadeInTimeInSeconds)
        {
            //Fade In
            float alphaChange = Time.deltaTime / fadeInTimeInSeconds;
            currentColor.a -= alphaChange;
            fadePanel.color = currentColor;
        }
        else {
            gameObject.SetActive(false);
        }
    }
}
