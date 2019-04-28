using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fadein : MonoBehaviour
{
    public int fadeIntime;

    private Image fadePanel;
    private Color currentcolor = Color.black;
    // Start is called before the first frame update
    void Start()
    {
        fadePanel = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeSinceLevelLoad < fadeIntime)
        {
            float alpahChange = Time.deltaTime / fadeIntime;
            currentcolor.a -= alpahChange;
            fadePanel.color = currentcolor;
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
