using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatSound : MonoBehaviour
{
    public AudioSource beat1;
    public AudioSource beat2;

    public void Hit1() {
        beat1.Play();
    }
    public void Hit2() {
        beat2.Play();
    }
}
