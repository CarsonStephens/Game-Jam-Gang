using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Attacking : MonoBehaviour
{
    Scene scene;
    public GameObject Player;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        scene = SceneManager.GetActiveScene();
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(scene.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            if (Player.GetComponent<PlayerController>().facingright == true)
            {
                if (Player.transform.position.x < transform.position.x && Mathf.Abs(Player.transform.position.x - transform.position.x) < 2)
                {
                    Destroy(gameObject);
                }
            }
            else
            {
                if (Player.transform.position.x > transform.position.x && Mathf.Abs(Player.transform.position.x - transform.position.x) < 2)
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}
