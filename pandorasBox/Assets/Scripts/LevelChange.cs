using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelChange: MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (this.gameObject.name == "door2")
        {
            SceneManager.LoadScene(sceneName: "level2");
        }
        if (this.gameObject.name == "door3")
        {
            SceneManager.LoadScene(sceneName: "level3");
        }
        if (this.gameObject.name == "doorFinal")
        {
            Invoke("finalLevel", 2);
        }
    }

    private void finalLevel()
    {
        SceneManager.LoadScene(sceneName: "victory");
    }
}

