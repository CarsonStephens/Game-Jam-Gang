/*
    Name: Nicholas Santos
    Date: 11/6/2020
    Desc: Movement
*/

using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyTracking : MonoBehaviour
{
    public GameObject Target;
    public float Speed = 0.5f;
    private bool LookingRight = true;
    Rigidbody2D myRb;

    //this is for animations (By Gavin Fifer)
    Rigidbody2D rb;
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
        if (Target.transform.position.x > transform.position.x && Target.transform.position.x - 5 < transform.position.x)
        {
            LookingRight = true;
            transform.Translate(2 * Time.deltaTime * Speed, 0, 0);

            //Animation stuff (Gavin Fifer)
            animator.SetFloat("Speed", 1);
            mySpriteRenderer.flipX = false;
        }
        else if (Target.transform.position.x < transform.position.x && Target.transform.position.x + 5 > transform.position.x)
        {
            LookingRight = false;
            transform.Translate(-2 * Time.deltaTime * Speed, 0, 0);

            //Animation stuff (Gavin Fifer)
            animator.SetFloat("Speed", 1);
            mySpriteRenderer.flipX = true;
        }
        else
        {
            animator.SetFloat("Speed", 0);
        }

        

        
    }
}
