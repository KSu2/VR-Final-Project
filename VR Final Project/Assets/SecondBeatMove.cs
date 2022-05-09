using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondBeatMove : MonoBehaviour
{
    public GameObject beat;


    // Update is called once per frame
    void Update()
    {
        if (gameObject.name.Contains("Clone"))
        {
            beat.transform.Translate(0f, 0.0f, 0.005f);
        }
    }
}
