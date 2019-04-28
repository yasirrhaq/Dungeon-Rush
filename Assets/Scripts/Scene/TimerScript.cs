using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    public Text scoreText;
    float time;
    int second;

    private float waitTime = 2.0f;


    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time > waitTime)
        {
            time = time - waitTime;
            second += 1;
            GameMaster.instance.score = second;
            scoreText.text = second.ToString();
            
            if (second % 7 == 0 && second != 0)
            {
                Debug.Log("fallspeed :" + GroundScript.fallSpeed);
                GroundScript.fallSpeed += 0.5f;
                
            }
        }        

    }

}
