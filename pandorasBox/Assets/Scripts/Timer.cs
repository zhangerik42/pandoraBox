using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public int remTime = 30;
    public Text txt;

    // Start is called before the first frame update
    void Start()
    {
      //  txt.text = remTime;
    }

    // Update is called once per frame
    void Update()
    {
        remTime -= (int) Time.deltaTime;

        if (remTime == 0)
        {
            // end game;
        }
    }
}