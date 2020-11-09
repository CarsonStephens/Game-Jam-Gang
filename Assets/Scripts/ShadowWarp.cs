using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Tyler D
//11/4/2020
//main mechanic
public class ShadowWarp : MonoBehaviour
{
    private Rigidbody2D rbPlayer;  
    //set this as an empty gameobject
    public GameObject teleSpot;   
    private float lastDirHeld;
    // Start is called before the first frame update
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody2D>();       
    }

    // Update is called once per frame
    void Update()
    {
        getDir();       
        
        if (Input.GetKeyDown("e"))
        {
            switch(lastDirHeld)
            {
                case 0:
                    break;
                case 1:
                    Vector2 newDir1 = new Vector2(0, 1);
                    rbPlayer.velocity = newDir1.normalized * rbPlayer.velocity.magnitude;
                    break;
                case 2:
                    Vector2 newDir2 = new Vector2(-1, 0);
                    rbPlayer.velocity = newDir2.normalized * rbPlayer.velocity.magnitude;
                    break;
                case 3:
                    Vector2 newDir3 = new Vector2(0, -1);
                    rbPlayer.velocity = newDir3.normalized * rbPlayer.velocity.magnitude;
                    break;
                case 4:
                    Vector2 newDir4 = new Vector2(1, 0);
                    rbPlayer.velocity = newDir4.normalized * rbPlayer.velocity.magnitude;
                    break;
            }
            rbPlayer.position = teleSpot.transform.position;
        }
        if (Input.GetKeyDown("q"))
        {
            teleSpot.transform.position = rbPlayer.position;
        }

    }

    void getDir()
    {
        if (Input.GetKeyDown("w"))
        {
            lastDirHeld = 1;
        }
        if (Input.GetKeyDown("a"))
        {
            lastDirHeld = 2;
        }
        if (Input.GetKeyDown("s"))
        {
            lastDirHeld = 3;
        }
        if (Input.GetKeyDown("d"))
        {
            lastDirHeld = 4;
        }
    }

    
}
