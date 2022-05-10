using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueStickAni : MonoBehaviour
{
    [SerializeField] private Animation anim;
    // Start is called before the first frame update
    void Start()
    {
        Animation anim = gameObject.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire2"))
        {
            anim.Play("BlueStickAnim");
        }
    }
}
