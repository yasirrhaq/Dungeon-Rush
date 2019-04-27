using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitGroundScript : MonoBehaviour
{
    public GameObject initalGround;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            initalGround.GetComponent<Rigidbody2D>().isKinematic = false;
            initalGround.GetComponent<Rigidbody2D>().gravityScale = 1;
            
        }
        Vector3 screenToPoint = Camera.main.WorldToViewportPoint(transform.position);
        bool offPosition = screenToPoint.y < -1;
        if (offPosition)
        {
            gameObject.SetActive(false);
        }
    }
}
