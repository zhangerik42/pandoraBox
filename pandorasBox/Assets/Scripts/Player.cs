using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void Start()
    {
        gameObject.GetComponent<recognizeSensorInput>().darknessActive = true;
    }
    public void shineLight()
    {
        gameObject.GetComponent<recognizeSensorInput>().darknessActive = false;
    }
}
