/*
    Name: Nicholas Santos
    Date: 11/6/2020
    Desc: Movement
*/

using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyTracking : MonoBehaviour
{
    public GameObject Target;
    public float Speed = 0.5f;
    private bool LookingRight = true;
    Rigidbody2D myRb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Target.transform.position.x > transform.position.x)
        {
            LookingRight = true;
            transform.Translate(2 * Time.deltaTime * Speed, 0, 0);
            transform.localScale = new Vector2 (2, 2);
        }
        else
        {
            LookingRight = false;
            transform.Translate(-2 * Time.deltaTime * Speed, 0, 0);
            transform.localScale = new Vector2 (2, 2);
        }
    }
}
