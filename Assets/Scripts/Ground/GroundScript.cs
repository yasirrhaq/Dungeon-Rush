using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScript : MonoBehaviour
{
    public static float fallSpeed = 1;
    public Transform nextGround;
    private float screenSize;
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //Obstacle speed following the GameMaster
        rb2d.velocity = new Vector2(0, -1 * fallSpeed);

        Vector3 screenToPoint = Camera.main.WorldToViewportPoint(transform.position);
        bool offPosition = screenToPoint.y < -1;
        if (offPosition){
            Vector3 newPosition = new Vector3(rb2d.position.x, nextGround.position.y + 10, 0);
            transform.position = newPosition;

            }
        }
    }

    


