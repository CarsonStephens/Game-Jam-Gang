﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
//Tyler D
//11/4/2020
//buttons or somethin
public class button : MonoBehaviour
{  
    //set this as the door you want to be opened
    public GameObject door;
    //set this if you want the door to close after x ammount of time
    public bool isTimed;
    //this sets the duration the door is open for
    public float timerDuration = 0;
    private float timer;
    private bool buttonActive;
    Color OrigionalDoorColor, OrigionalColor;

    SpriteRenderer mySR;
    // Start is called before the first frame update
    void Start()
    {
        timer = timerDuration;
        door.GetComponent<BoxCollider2D> ().enabled = GetComponent<BoxCollider2D> ().enabled;
        mySR = GetComponent<SpriteRenderer>();
        OrigionalDoorColor = new Color(door.GetComponent<SpriteRenderer>().color.r, door.GetComponent<SpriteRenderer>().color.g, door.GetComponent<SpriteRenderer>().color.b, 1f);
        OrigionalColor = new Color(mySR.color.r, mySR.color.g, mySR.color.b, 1f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isTimed == true && buttonActive == true)
        {
            if (timer <= 0)
            {
                buttonActive = false;
                timer = timerDuration;
                GetComponent<BoxCollider2D> ().enabled = true;
                mySR.color = OrigionalColor;
                door.GetComponent<SpriteRenderer>().color = OrigionalDoorColor;
            }
            else
            {
                timer -= Time.deltaTime;
                GetComponent<BoxCollider2D> ().enabled = false;
                mySR.color = new Color(OrigionalColor.r - 0.5f, OrigionalColor.g - 0.5f, OrigionalColor.b - 0.5f, 1f);
                door.GetComponent<SpriteRenderer>().color = new Color(OrigionalDoorColor.r - 0.1f, OrigionalDoorColor.g - 0.1f, OrigionalDoorColor.b - 0.1f, 1f);
            }
        }
        else if (buttonActive == true)
        {
            GetComponent<BoxCollider2D> ().enabled = false;
            mySR.color = new Color(OrigionalColor.r - 0.5f, OrigionalColor.g - 0.5f, OrigionalColor.b - 0.5f, 1f);
            door.GetComponent<SpriteRenderer>().color = new Color(OrigionalDoorColor.r - 0.5f, OrigionalDoorColor.g - 0.5f, OrigionalDoorColor.b - 0.5f, 1f);
        }
        else
        {
            mySR.color = OrigionalColor;
            door.GetComponent<SpriteRenderer>().color = OrigionalDoorColor;
        }
        door.GetComponent<BoxCollider2D>().enabled = GetComponent<BoxCollider2D>().enabled;
    }

    private void OnTriggerEnter2D(Collider2D collision)    
    {        
        //make sure player is tagged as "Player"
        if (collision.gameObject.tag == "Player")
        {           
            buttonActive = true;
        }
    }
   
}
