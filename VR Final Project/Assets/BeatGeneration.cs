using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class BeatGeneration : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject beat;
    public GameObject beat2;
    private GameObject newbeat;
    string beatmap_path = "Assets/Beatmap/Beatmap.txt";
    int curr_beat = 0;
    void Start()
    {
        StartCoroutine(readMap(beatmap_path));
    }

    // Update is called once per frame
    void Update()
    {

        if (curr_beat != 0)
        {
            if (!gameObject.name.Contains("Clone"))
            {
                Debug.Log("Beat Creation");
                Debug.Log(curr_beat);
                if (curr_beat == 49) { 
                    newbeat = Instantiate(beat, new Vector3(-20.0f, 2.0f, 0.0f), Quaternion.identity);
                    newbeat.transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
                }
                if (curr_beat == 50)
                {
                    newbeat = Instantiate(beat2, new Vector3(-20.0f, 2.0f, 0.0f), Quaternion.identity);
                    newbeat.transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
                }
                curr_beat = 0;
            }
        }
        if (gameObject.name.Contains("Clone"))
        {
            beat.transform.Translate(0f, 0.0f, 0.005f);
        }
    }
    IEnumerator readMap(string map)
    {
        StreamReader inputs = new StreamReader(map);
        while (!inputs.EndOfStream)
        {
            string currline = inputs.ReadLine();
            curr_beat = Convert.ToInt32(currline[0]);
            float timeToWait = Convert.ToSingle(currline.Substring(1));
            yield return new WaitForSeconds(timeToWait);
        }
    }


    }
