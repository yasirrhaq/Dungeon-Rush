﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataDeleter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.DeleteAll();   
    }
}
