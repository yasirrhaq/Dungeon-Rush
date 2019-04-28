using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopLoader : MonoBehaviour
{
    public Image imageShop;

    public void GotoShop()
    {
        imageShop.gameObject.SetActive(true);
       
    }
}
