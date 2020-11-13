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
            if (Player.GetComponent<PlayerController> ().facingright == true)
            {
                if (Player.GetComponent<Transform> ().position.x - GetComponent<Transform> ().position.x < 0 && Player.GetComponent<Transform>().position.x - GetComponent<Transform>().position.x >= -2)
                {
                    Destroy(gameObject);
                }
            }
            else
            {
                if (Player.GetComponent<Transform>().position.x - GetComponent<Transform>().position.x > 0 && Player.GetComponent<Transform>().position.x - GetComponent<Transform>().position.x <= 2)
                {
                    Destroy(gameObject);
                }
            }
    }
}
