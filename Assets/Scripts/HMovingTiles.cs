/*
Name: Nicholas Santos
Date: 11/6/20
Desc: Moves Tiles Horozontally
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HMovingTiles : MonoBehaviour
{
    public float Speed = 1, MovementFor = 3;
    private float i = 0;
    public bool MovingRight = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (MovingRight == true)
        {
            transform.position = new Vector2(transform.position.x + Speed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - Speed * Time.deltaTime, transform.position.y);
        }
        i += Time.deltaTime;
        if (MovementFor < i)
        {
            i = 0;
            if (MovingRight == true)
            {
                MovingRight = false;
            }
            else
            {
                MovingRight = true;
            }
        }
    }
}
