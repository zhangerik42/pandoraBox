using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision){
        //destroy this object when it collides w the player
        Destroy(this.gameObject);
    }
}
