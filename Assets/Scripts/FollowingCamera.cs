﻿//////////////////
///By: Andrew Kitzan
///Date: 11/10/20
///Description: This is a script meant to be added to a camera to follow a specified target
//////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingCamera : MonoBehaviour
{
    public GameObject Target;
    public float smoothVal = 0.5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void FixedUpdate()
    {
        if (Target != null)
        {
            //Figure out where the target is
            Vector3 newPos = Target.transform.position;
            //maintain camera z level
            newPos.z = transform.position.z;
            //use linear interpolation to smoothly go to the target
            transform.position = Vector3.Lerp(transform.position, newPos, smoothVal);
        }
    }
}
