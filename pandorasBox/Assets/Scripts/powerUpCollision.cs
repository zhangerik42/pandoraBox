using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    bool isCollided =  false;

    private void OnCollisionEnter2D(Collision2D collision){
        //Detsroys object that collides with
        //the object that this script is attached to
        Destroy(collision.GameObject);
    }

    // Update is called once per frame
    void Update()
    {

        if(isCollided == true)
        {
            //destroy the powerup
            
            Destroy(this);
        }
    }
}
