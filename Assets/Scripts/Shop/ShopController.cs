using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopController : MonoBehaviour
{
    public Image menuImage;
    public Image shopMenuImage;

    public Image imageCostumePreview;
    public Text itemPricePreview;

    public Costume[] costumeItemList;
    int currentIndex = 0;

    void OnEnable()
    {
        imageCostumePreview.sprite = costumeItemList[0].costumeImage;
        itemPricePreview.text = "Equip";
    }

    public void backButton()
    {
        menuImage.gameObject.SetActive(true);
        gameObject.SetActive(false);
    }

    public void RightButton()
    {
        currentIndex++;

        string costumeList = PlayerPrefs.GetString("costumeListIndex");

        if (currentIndex >= costumeItemList.Length) { currentIndex = 0; }
        imageCostumePreview.sprite = costumeItemList[currentIndex].costumeImage;
        if (costumeList.Contains(currentIndex.ToString()) || currentIndex == 0)
        {
            itemPricePreview.text = "Equip";
        }
        else
        {
            itemPricePreview.text = "x" + costumeItemList[currentIndex].price.ToString();
        }
    }

    public void LeftButton()
    {
        currentIndex-=1;

        string costumeList = PlayerPrefs.GetString("costumeListIndex");

        if (currentIndex < 0) { currentIndex = costumeItemList.Length - 1; }
        imageCostumePreview.sprite = costumeItemList[currentIndex].costumeImage;
        if (costumeList.Contains(currentIndex.ToString()) || currentIndex == 0)
        {
            itemPricePreview.text = "Equip";
        }
        else
        {
            itemPricePreview.text = "x" + costumeItemList[currentIndex].price.ToString();
        }        
    }

    public void buyButton()
    {
        string costumeList = PlayerPrefs.GetString("costumeListIndex");

        if (costumeList.Contains(currentIndex.ToString()))
        {
            PlayerPrefs.SetInt("characterIndex", currentIndex);
        }
        else
        {
            int myCoin = PlayerPrefs.GetInt("coin");
            int itemPrice = costumeItemList[currentIndex].price;
            if (itemPrice < myCoin)
            {
                myCoin = myCoin - itemPrice;
                PlayerPrefs.SetInt("coin", myCoin);
                //Save the costume
                PlayerPrefs.SetString("costumeListIndex", currentIndex.ToString());
                itemPricePreview.text = "Equip";
            }
            else
            {
                Debug.Log("Not Enough money");
            }
        }

    }
}
