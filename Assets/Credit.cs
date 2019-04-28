using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credit : MonoBehaviour
{
    public GameObject creditpanel;

    public void showCredit()
    {
        creditpanel.SetActive(true);

    }

    public void hideCredit()
    {
     
        creditpanel.SetActive(false);
        
    }
}
