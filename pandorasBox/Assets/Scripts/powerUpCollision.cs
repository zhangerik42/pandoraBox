using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision){
        //Detsroys object that collides with
        //the obt that this script is attached tojec
        Destroy(collision.gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
