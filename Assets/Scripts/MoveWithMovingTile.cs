using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithMovingTile : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D tile)
    {
        transform.parent = tile.transform;
    }   
    private void OnCollisionExit2D(Collision2D tile)
    {
        transform.parent = null;
    }
}
