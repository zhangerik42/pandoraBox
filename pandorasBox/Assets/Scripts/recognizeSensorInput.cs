using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recognizeSensorInput : MonoBehaviour
{
    public bool lightActive;
    public bool flameOn;

    public GameObject darkness;
    public GameObject fireBreath;
    //
    // Start is called before the first frame update
    void Start()
    {
        darkness.SetActive(true);
        lightActive = false;
        flameOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (lightActive)
        {
            darkness.SetActive(false);
        }

        if (flameOn)
        {
            fireBreath.SetActive(true);
            //this.GetComponent<SpriteRenderer>().sprite = fireBreathSprite;
        }
    }
}
