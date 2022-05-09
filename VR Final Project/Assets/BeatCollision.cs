using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatCollision : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerStay(Collider collision)
    {
        Debug.Log("Colliding");
        if (Input.GetButton("Fire1"))
        {
            if (collision.gameObject.name == "Ring")
            {
                if (gameObject.name == "Beat(Clone)" || gameObject.name == "Beat2(Clone)")
                {
                    Destroy(gameObject);
                    /*TODO: UPDATE POINT TRACKER AND DESTRUCTION EFFECT*/
                }
            }
            else if (collision.gameObject.name == "Destruction Box")
            {
                if (gameObject.name == "Beat(Clone)" || gameObject.name == "Beat2(Clone)")
                {
                    Destroy(gameObject);
                    /*TODO: UPDATE POINT TRACKER AND DESTRUCTION EFFECT*/
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
                /*TODO: UPDATE POINT TRACKER AND DESTRUCTION EFFECT*/
            }
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
