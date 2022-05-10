using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class BeatCollision : MonoBehaviour
{
    public GameObject gui;
    private Text txt;
    private TextStart textStart;
    private BeatSound beatSound;

    // Start is called before the first frame update
    void Start()
    {
        txt = gui.GetComponent<Text>();
        textStart = txt.GetComponent<TextStart>();
        beatSound = gameObject.GetComponent<BeatSound>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerStay(Collider collision)
    {
        /*Debug.Log("Colliding");*/
        if (Input.GetButton("Fire1"))
        {
            if (collision.gameObject.name == "Ring")
            {
                if (gameObject.name == "Beat(Clone)")
                {
                    Debug.Log("hit ring");
                    Destroy(gameObject);
                    ScoreHandler((int)Math.Floor(100*(Math.Log10(textStart.combo + 1))), 1);
                    beatSound.Hit1();
                    

                }
            }
            else if (collision.gameObject.name == "Late Box")
            {
                if (gameObject.name == "Beat(Clone)")
                {
                    Debug.Log("hit late");
                    Destroy(gameObject);
                    ScoreHandler((int)Math.Floor(100*(Math.Log10(textStart.combo + 1))), 1);
                    beatSound.Hit1();

                }
            }
            else if (collision.gameObject.name == "Early Box")
            {
                if (gameObject.name == "Beat(Clone)")
                {
                    Destroy(gameObject);
                    ScoreHandler((int)Math.Floor(100*(Math.Log10(textStart.combo + 1))), 1);
                    beatSound.Hit1();
                }
            }
        }
        else if (Input.GetButton("Fire2"))
        {
            if (collision.gameObject.name == "Ring")
            {
                if (gameObject.name == "Beat2(Clone)")
                {
                    Destroy(gameObject);
                    ScoreHandler((int)Math.Floor(100*(Math.Log10(textStart.combo + 1))), 1);
                    beatSound.Hit2();
                }
            }
            else if (collision.gameObject.name == "Late Box")
            {
                if (gameObject.name == "Beat2(Clone)")
                {
                    Destroy(gameObject);
                    ScoreHandler((int)Math.Floor(100*(Math.Log10(textStart.combo + 1))), 1);
                    beatSound.Hit2();
                }
            }
            else if (collision.gameObject.name == "Early Box")
            {
                if (gameObject.name == "Beat2(Clone)")
                {
                    Destroy(gameObject);
                    ScoreHandler((int)Math.Floor(100*(Math.Log10(textStart.combo + 1))), 1);
                    beatSound.Hit2();
                }
            }
        }
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Miss Box")
        {
            if (gameObject.name == "Beat(Clone)" || gameObject.name == "Beat2(Clone)")
            {
                Destroy(gameObject);
                ScoreHandler(0, 0);
            }
        }
    }
    void ScoreHandler(int score, int combo)
    {

        textStart.score += score;

        if (combo > 0)
        {
           textStart.combo +=1;
        }
        else
        {
            textStart.combo = 0;
        }

    }



    /*            if (Input.GetButton("Fire1"))
            { 
                 HitBeat("left", Collision collision);
}
void HitBeat(string side, collision)
   {
       if(collision.gameObject.name == "Ring")
       {
           if(gameObject.name == "Beat(Clone)")
           {
               Destroy(gameObject);
               TODO: UPDATE POINT TRACKER AND DESTRUCTION EFFECT
           }
       }
   }*/
}
