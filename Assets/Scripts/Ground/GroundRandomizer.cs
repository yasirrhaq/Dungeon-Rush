using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundRandomizer : MonoBehaviour
{
    public GameObject[] _groundPrefab;

    private void Start()
    {
        RandomGround();
    }

    public void RandomGround()
    {
        for(int i=0; i<_groundPrefab.Length; i++)
        {
            _groundPrefab[i].SetActive(false);
        }
        _groundPrefab[Random.Range(0, _groundPrefab.Length)].SetActive(true);

        
    }

    void Update()
    {
        Vector3 screenToPoint = Camera.main.WorldToViewportPoint(transform.position);
        bool offPosition = screenToPoint.y < -1;
        if (offPosition)
        {
            RandomGround();
        }
    }
}
