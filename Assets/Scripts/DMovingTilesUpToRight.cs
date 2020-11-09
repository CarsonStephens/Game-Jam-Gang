/*
Name: Nicholas Santos
Date: 11/6/20
Desc: Moves Tiles Horozontally
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DMovingTilesUpToRight : MonoBehaviour
{
    public float Speed = 1, MovementFor = 3;
    public bool MovetoUpperRight = true, MovingUp;
    private float i = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (MovetoUpperRight == true)
        {
            if (MovingUp == true)
            {
                transform.position = new Vector2(transform.position.x + Speed * Time.deltaTime, transform.position.y + Speed * Time.deltaTime);
            }
            else
            {
                transform.position = new Vector2(transform.position.x - Speed * Time.deltaTime, transform.position.y - Speed * Time.deltaTime);
            }
        }
        else
        {
            if (MovingUp == true)
            {
                transform.position = new Vector2(transform.position.x - Speed * Time.deltaTime, transform.position.y + Speed * Time.deltaTime);
            }
            else
            {
                transform.position = new Vector2(transform.position.x + Speed * Time.deltaTime, transform.position.y - Speed * Time.deltaTime);
            }
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
