using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    Scene scene;

    // Update is called once per frame
    void Update()
    {
        scene = SceneManager.GetActiveScene();
        if (GetComponent<Transform>().position.y < -10)
        {
            SceneManager.LoadScene("Level1");
        }
        if (scene.name == "Level1")
        {
            if (GetComponent<Transform>().position.x > 32)
            {
                SceneManager.LoadScene("Level2");
            }
        }
        if (scene.name == "Level2")
        {
            if (GetComponent<Transform>().position.x > 32)
            {
                SceneManager.LoadScene("Level3");
            }
        }
    }
}
