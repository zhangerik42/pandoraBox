using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerMove : MonoBehaviour
{
    public float speed = 100;
    public Rigidbody2D rb;
    public SpriteRenderer sr;

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // if moving right, flip character
        if(h > 0)
        {
            sr.flipX = true;
            gameObject.GetComponentInChildren<SpriteRenderer>().flipX = true;
        }

        if(h < 0)
        {
            sr.flipX = false;
        }

        if (h == 0 && v == 0)
        {

        }
        else
        {
            Vector3 tempVect = new Vector3(h, v, 0);
            tempVect = tempVect.normalized * speed * Time.deltaTime;
            rb.MovePosition(rb.transform.position + tempVect);
        }
    }
}
