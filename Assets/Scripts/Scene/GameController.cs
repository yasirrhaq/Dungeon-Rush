using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Text gameOverText;
    private GameObject player;
    public GameObject deathPanel;
    public Text cointText;
    public Text scoreText;
    public GameObject scoreUI;
    // Start is called before the first frame update
    void Start()
    {        
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
            player = GameObject.FindGameObjectWithTag("Player");

        RestartGame();
    }

    void PauseGame()
    {

    }

    void RestartGame()
    {
        if (player)
        {
            Vector3 screenToPoint = Camera.main.WorldToViewportPoint(player.transform.position);
            bool offPosition = screenToPoint.y < 0;
            if (offPosition)
            {
                //gameOverText.gameObject.SetActive(true);
                //gameOverText.text = "Game Over ";
                deathPanel.SetActive(true);
                cointText.text = GameMaster.instance.currentCoin.ToString();
                scoreText.text = GameMaster.instance.score.ToString();
                scoreUI.SetActive(false);
                Time.timeScale = 0;
                if (Input.GetKeyDown(KeyCode.R))
                {
                    //Load current scene
                   
                }
            }
        }

    }
    
    public void Retry()
    {
        scoreUI.SetActive(true);
        deathPanel.SetActive(false);
        GameMaster.instance.allCoin += GameMaster.instance.currentCoin;
        GameMaster.instance.currentCoin = 0;
        GameMaster.instance.SaveState();
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void Menu()
    {

    }

}
