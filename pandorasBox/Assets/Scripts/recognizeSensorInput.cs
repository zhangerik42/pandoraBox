using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recognizeSensorInput : MonoBehaviour
{
    public bool lightActive;
    public bool fireBreathActive;

    public GameObject darkness;
    public GameObject fireBreath;
    //
    // Start is called before the first frame update
    void Start()
    {
        darkness.SetActive(true);
        lightActive = false;
        fireBreathActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (lightActive)
        {
            darkness.SetActive(false);
        }

        if (fireBreathActive)
        {
            fireBreath.SetActive(true);
            //this.GetComponent<SpriteRenderer>().sprite = fireBreathSprite;
        }
    }
}
