using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recognizeSensorInput : MonoBehaviour
{
    public bool lightActive;
    public GameObject light;
    //
    // Start is called before the first frame update
    void Start()
    {
        lightActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        light.SetActive(lightActive);
    }
}
