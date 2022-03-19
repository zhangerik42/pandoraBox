using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recognizeSensorInput : MonoBehaviour
{
    public bool darknessActive;
    public GameObject darkness;
    //
    // Start is called before the first frame update
    void Start()
    {
        darknessActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!darknessActive)
        {
            darkness.SetActive(false);
        }
    }
}
