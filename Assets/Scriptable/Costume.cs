using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Costume", menuName = "Shop/Costume", order = 1)]
public class Costume : ScriptableObject
{
    public Sprite costumeImage;
    public int price;
}
