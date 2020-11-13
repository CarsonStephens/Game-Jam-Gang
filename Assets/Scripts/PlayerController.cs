using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Tyler Dean
//10/19/2020
//haha movement go brrrr
public class PlayerController : MonoBehaviour
{
    public float Speed = 500;
    public float jumpHeight = 200;    
    Rigidbody2D rb;
    public bool hasJump = false, facingright = true;

    //this is for animations (By Gavin Fifer)
    public Animator animator;
    private SpriteRenderer mySpriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {        
        Vector2 movement = new Vector2();

        movement.x = Input.GetAxisRaw("Horizontal");               
        rb.AddForce(transform.right * movement.x * Speed * Time.deltaTime);
        

        //Sets Speed value to the player movement speed (By Gavin Fifer)
        animator.SetFloat("Speed", Mathf.Abs(movement.x));
        movement.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Is Jumping", rb.velocity.y);

        //Flips sprite to correct direction (By Gavin Fifer)
        if (movement.x < 0)
        {
            mySpriteRenderer.flipX = true;
            facingright = false;
        }
        else if (movement.x > 0)
        {
            mySpriteRenderer.flipX = false;
            facingright = true;
        }

        if (hasJump == true)
        {
            if (Input.GetKeyDown("space"))
            {
                rb.AddForce(transform.up * jumpHeight);
            }
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground" || collision.gameObject.tag == "Moving")
        {
            hasJump = true;
        }
    }

    /*private void OnCollision2D(Collision2D collision)    
    {        
        if (collision.gameObject.tag == "ground" || collision.gameObject.tag == "Moving")
        {
            hasJump = true;
        }
    }*/

    private void OnCollisionExit2D(Collision2D collision)
    {
        //make sure to tag all walkable surfaces as ground
        if (collision.gameObject.tag == "ground" || collision.gameObject.tag == "Moving")
        {            
            hasJump = false;
        }
    }
}
