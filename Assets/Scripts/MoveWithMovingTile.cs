using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithMovingTile : MonoBehaviour
{
    private Vector3 velocity;
    private bool moving;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        moving = true;
        collision.collider.transform.SetParent(transform);
    }   
    private void OnCollisionExit2D(Collision2D collision)
    {
        moving = false;
        collision.collider.transform.SetParent(null);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(moving)
        {
            transform.position += (velocity * Time.deltaTime);
        }

    }
}
