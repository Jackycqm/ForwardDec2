using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesSpawn : MonoBehaviour
{
    private float songPositionSeconds;
    //The current position of the song in seconds

    private float songPositionBeats;
    //The current position of the song in beats
    //BPM (Beats Per Minutes) is calculated

    private float secondsPerbeat;
    //How long is a beat in seconds

    private float dsptimesong;
    //AudioSettings.dspTime
    //https://docs.unity3d.com/2019.1/Documentation/ScriptReference/AudioSettings-dspTime.html
    //how many seconds has passed since song started
    //Only tracks seconds based on the actual number of samp-les of the audio system passes

    // Start is called before the first frame update
    private void Start()
    {
        //secondsPerbeat = 60f / bpm;
        //calculated the duration of each beat in seconds
        //bpm will be declared later

        dsptimesong = (float)AudioSettings.dspTime;
        //start keeping track of time with song starts

        GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    private void Update()
    {
    }
}