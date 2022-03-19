using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision){
        //destroy this object when it collides w the player
        Destroy(this.gameObject);
        // OMEGAA SPAGHETTI
        // when this powerup is attained, go to the colliding game object and turn off its darkness
        collision.gameObject.GetComponent<recognizeSensorInput>().darknessActive = false;
    }
}
