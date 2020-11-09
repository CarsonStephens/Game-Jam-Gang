/*
Name: Nicholas Santos
Date: 11/6/20
Desc: Moves Tiles Horozontally
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VMovingTiles : MonoBehaviour
{
    public float Speed = 1, MovementFor = 3;
    private float i = 0;
    public bool MovingUp = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (MovingUp == true)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + Speed * Time.deltaTime);
        }
        else
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - Speed * Time.deltaTime);
        }
        i += Time.deltaTime;
        if (MovementFor < i)
        {
            i = 0;
            if (MovingUp == true)
            {
                MovingUp = false;
            }
            else
            {
                MovingUp = true;
            }
        }
    }
}
