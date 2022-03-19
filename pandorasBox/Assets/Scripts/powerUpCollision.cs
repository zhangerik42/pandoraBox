using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision){
        //Detsroys object that collides with
        //the obt that this script is attached tojec
        Destroy(collision.GameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
