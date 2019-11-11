using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesSpawn : MonoBehaviour
{
    private float samplePositionSeconds;
    //The current position of the audio sample in seconds

    private float samplePositionBeats;
    //The current position of the audio sample in beats
    //BPM (Beats Per Minutes) is calculated

    private float secondsPerbeat;
    //How long is a beat in seconds

    private float dsptimeSample;
    //AudioSettings.dspTime
    //https://docs.unity3d.com/2019.1/Documentation/ScriptReference/AudioSettings-dspTime.html
    //How many seconds has passed since audio sample started
    //Only tracks seconds based on the actual number of samp-les of the audio system passes

    private float bpm;
    //beats per minutes
    //calculates tempo

    private float[] notes;
    //array that stores the position-in-beats of notes in an audio sample

    private int nextNote = 0;
    //keeps track of the notes

    // Start is called before the first frame update
    private void Start()
    {
        secondsPerbeat = 60f / bpm;
        //calculated the duration of each beat in seconds
        //bpm will be declared later
        //Tempo is calcualted in bpm

        dsptimeSample = (float)AudioSettings.dspTime;
        //start keeping track of time when audio sample starts

        GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    private void Update()
    {
        samplePositionSeconds = (float)(AudioSettings.dspTime - dsptimeSample);
        //Calculates position with a audio sample in seconds
        //Returns a float of [(How long is an audio sample based in seconds)-(How many seconds has passed since Sample started)]

        samplePositionBeats = samplePositionSeconds / secondsPerbeat;
        //converts the smaples system into beats system
        //a beat is x sceonds
        //beats are calculated based on bpm
        //how many beats are left then can be derived

        //if (nextNote < notes.Length && notes[nextNote] < samplePositionBeats + notesAlreadgyGenerated)
        //{
        //  Instantiate(RBeats);
        //Instantiate Notes for Drum Controller Interaction

        //nextNote++;
        //}
    }
}