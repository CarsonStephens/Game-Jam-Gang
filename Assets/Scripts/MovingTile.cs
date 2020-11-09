/*
Name: Nicholas Santos
Date: 11/6/20
Desc: Moves Tiles Horozontally
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTile : MonoBehaviour
{
    public float Speed = 1, MoveFor = 3;
    public bool MoveUp = false, MoveRight = false, InitiallyMoveUp = true, InitiallyMoveRight = true;
    private bool mup, mri;
    private float i = 0;

    private void Start()
    {
        mup = MoveUp;
        mri = MoveRight;
        if (InitiallyMoveUp == false)
        {
            if (mup == true)
            {
                mup = false;
            }
            else
            {
                mup = true;
            }
        }
        if (InitiallyMoveRight == false)
        {
            if (mri == true)
            {
                mri = false;
            }
            else
            {
                mri = true;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (MoveUp == true)
        {
            if (mup == true)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y + Speed * Time.deltaTime);
            }
            else
            {
                transform.position = new Vector2(transform.position.x, transform.position.y - Speed * Time.deltaTime);
            }
        }

        if (MoveRight == true)
        {
            if (mri == true)
            {
                transform.position = new Vector2(transform.position.x + Speed * Time.deltaTime, transform.position.y);
            }
            else
            {
                transform.position = new Vector2(transform.position.x - Speed * Time.deltaTime, transform.position.y);
            }
        }

        i += Time.deltaTime;
        if (i > MoveFor)
        {
            i = 0;
            if (MoveUp == true)
            {
                if (mup == true)
                {
                    mup = false;
                }
                else
                {
                    mup = true;
                }
            }
            if (MoveRight == true)
            {
                if (mri == true)
                {
                    mri = false;
                }
                else
                {
                    mri = true;
                }
            }
        }
    }
}
