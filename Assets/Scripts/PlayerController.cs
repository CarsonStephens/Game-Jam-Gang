using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Tyler Dean
//10/19/2020
//haha movement go brrrr
public class PlayerController : MonoBehaviour
{
    public float Speed = 500;
    public float jumpHeight = 200;    
    private bool isGrounded = false;    
    Rigidbody2D rb;
    bool hasJump = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();        
    }

    // Update is called once per frame
    void Update()
    {        
        Vector2 movement = new Vector2();

        movement.x = Input.GetAxisRaw("Horizontal");               
        rb.AddForce(transform.right * movement.x * Speed * Time.deltaTime);
        if (hasJump == true)
        {
            if (Input.GetKeyDown("space"))
            {
                rb.AddForce(transform.up * jumpHeight);
                hasJump = false;
            }
        }
        if (isGrounded == true && movement.x == 0 && hasJump == true)
        {
            rb.velocity = rb.velocity / 2;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)    
    {        
        if (collision.gameObject.tag == "ground")
        {
            hasJump = true;
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        //make sure to tag all walkable surfaces as ground
        if (collision.gameObject.tag == "ground")
        {            
            isGrounded = false;
        }
    }


}
