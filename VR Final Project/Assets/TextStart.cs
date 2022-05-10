using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextStart : MonoBehaviour
{
    Text txt;
    public int score = 0;
    public int combo = 0;
    // Start is called before the first frame update
    void Start()
    {
        txt = gameObject.GetComponent<Text>();
        txt.text = "Score: " + score + "\n Combo: " + combo;
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "Score: " + score + "\n Combo: " + combo;
    }
}
