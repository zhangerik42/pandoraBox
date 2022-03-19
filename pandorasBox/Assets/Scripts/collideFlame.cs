using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collideFlame : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        if(collision.gameObject.tag == "Wood")
        {
            Destroy(collision.gameObject);
        }
        
    }
}
