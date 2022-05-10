using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioStart : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource crabRave;
    void Start()
    {
        crabRave = GetComponent<AudioSource>();
        crabRave.time = 4.5f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
