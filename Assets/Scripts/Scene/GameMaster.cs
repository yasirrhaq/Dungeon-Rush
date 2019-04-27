using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public static GameMaster instance;
    public int score;
    public int currentCoin;
    public int allCoin;
    public float obstacleSpeed;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        if(instance == null)
        {
            instance = this;
        }else if(instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        LoadState();
    }

    void IncreaseObstacleSpeed()
    {
        bool increase = (score % 20 == 0) && (score != 0);
        if (increase) obstacleSpeed += 1;
    }

    public void SaveState()
    {
        PlayerPrefs.SetInt("coin", allCoin);
    }

    public void LoadState()
    {
        allCoin = PlayerPrefs.GetInt("coin");
    }
}
