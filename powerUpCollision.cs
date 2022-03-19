using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    bool isCollided =  false;

    // Update is called once per frame
    void Update()
    {
        if(isCollided == true)
        {
            //destroy the powerup
            this.SetActive(false);
        }
    }
}
