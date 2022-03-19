using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelChange: MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (this.gameObject.name == "door2")
        //destroy this object when it collides w the player{
        {
            Debug.Log("auibfiojasbfudioabijf");
            SceneManager.LoadScene(sceneName: "level2");
        }
        if (this.gameObject.name == "door3")
        //destroy this object when it collides w the player{
        {
            SceneManager.LoadScene(sceneName: "level3");
        }
    }
}

