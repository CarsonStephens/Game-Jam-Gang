using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
    SpriteRenderer mySR;
    // Start is called before the first frame update
    void Start()
    {
        timer = timerDuration;
        door.GetComponent<BoxCollider2D> ().enabled = GetComponent<BoxCollider2D> ().enabled;
        mySR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isTimed == true && buttonActive == true)
        {
            if (timer <= 0)
            {
                buttonActive = false;
                GetComponent<BoxCollider2D>().enabled = false;
                mySR.color = new Color(mySR.color.r - 0.5f, mySR.color.g - 0.5f, mySR.color.b - 0.5f, 1f);
                door.GetComponent<SpriteRenderer>().color = new Color(mySR.color.r, mySR.color.g, mySR.color.b, 1f);
                timer = timerDuration;
            }
            else
            {
                timer -= Time.deltaTime;
                GetComponent<BoxCollider2D>().enabled = false;
                mySR.color = new Color(mySR.color.r - 0.5f, mySR.color.g - 0.5f, mySR.color.b - 0.5f, 1f);
                door.GetComponent<SpriteRenderer>().color = new Color(mySR.color.r - 0.5f, mySR.color.g - 0.5f, mySR.color.b - 0.5f, 1f);
            }
        }
        if (buttonActive == true)
        {
            GetComponent<BoxCollider2D> ().enabled = false; 
            mySR.color = new Color(mySR.color.r - 0.5f, mySR.color.g - 0.5f, mySR.color.b - 0.5f, 1f);
            door.GetComponent<SpriteRenderer>().color = new Color(mySR.color.r - 0.5f, mySR.color.g - 0.5f, mySR.color.b - 0.5f, 1f);
        }
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
