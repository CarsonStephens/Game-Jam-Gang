using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
/*
Name: Nicholas Santos
Date: 11/13/2020
Desc: Attack for enemy and player, placed on enemy
 */
public class Attacking : MonoBehaviour
{
    Scene scene;
    public GameObject player;
    public UnityEvent OnCollide = new UnityEvent();
    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<PlayerController> ().facingright == true)
        {
            if (player.GetComponent<Transform>().position.x < GetComponent<Transform>().position.x && player.GetComponent<Transform>().position.x > GetComponent<Transform>().position.x - 1)
            {
                Destroy(gameObject);
            }
        }
        else
        {
            if (player.GetComponent<Transform>().position.x > GetComponent<Transform>().position.x && player.GetComponent<Transform>().position.x < GetComponent<Transform>().position.x + 1)
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        scene = SceneManager.GetActiveScene();
        if (collision.gameObject.tag == "Player")
        {
            OnCollide.Invoke();
            SceneManager.LoadScene(scene.name);
        }
    }
}
