using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hazard : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // play death sound?
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(sceneName: "deathScreen");
        }
    }
}
