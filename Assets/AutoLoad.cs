using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoLoad : MonoBehaviour
{
    public float autoLoadNextLevel;
    // Start is called before the first frame update
    void Start()
    {
        if(autoLoadNextLevel >= 0)
        {
            Invoke("LoadNextLevel", autoLoadNextLevel);
        }
    }

    void LoadNextLevel()
    {
        int x = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(x + 1);
    }
}
