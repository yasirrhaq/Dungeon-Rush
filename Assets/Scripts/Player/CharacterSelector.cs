using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelector : MonoBehaviour
{
    public GameObject[] playerList;

    // Start is called before the first frame update
    void Awake()
    {
        int index;

        try
        {
            index = PlayerPrefs.GetInt("characterIndex");
        }catch(PlayerPrefsException e)
        {
            Debug.Log(e.Message);
            index = 0;
        }

        playerList[index].SetActive(true);
    }

}
