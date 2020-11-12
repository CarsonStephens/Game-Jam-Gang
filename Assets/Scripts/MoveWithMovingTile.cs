using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithMovingTile : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Moving")
        {
            transform.parent = collision.transform;
        }
    }   
    private void OnCollisionExit2D(Collision2D collision)
    {
        transform.parent = null;
    }
}
