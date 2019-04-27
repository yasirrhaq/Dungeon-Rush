using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundRandomizer : MonoBehaviour
{
    public GameObject[] _groundPrefab;

    public void RandomGround()
    {
        for(int i=0; i<_groundPrefab.Length; i++)
        {
            _groundPrefab[i].SetActive(false);
        }
        _groundPrefab[Random.Range(0, _groundPrefab.Length)].SetActive(true);

        
    }
}
