using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cointSpawner : MonoBehaviour
{
    public GameObject[] coin;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 screenToPoint = Camera.main.WorldToViewportPoint(transform.position);
        bool offPosition = screenToPoint.y < -1;
        if (offPosition)
        {
            if (coin != null)
            {
                for (int i = 0; i < coin.Length; i++)
                {
                    coin[i].SetActive(true);
                }
            }
        }
    }
}
