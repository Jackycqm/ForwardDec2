using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesSpawnTest : MonoBehaviour
{
    //public GameObject LNotes;
    //public GameObject RNotes;

    public Transform LOrigin;
    public Transform ROrigin;
    public Transform LDestination;
    public Transform RDestination;

    private float LTrackLength;
    private float RTrackLength;

    public float startTime;

    public float Speed = 1.0f;

    private void Start()
    {
    }

    private void Update()
    {
        LNoteMovement();
        Debug.Log(LOrigin.position);
    }

    private void LNoteMovement()
    {
        float LTrackDistanceTraveled = (Time.time - startTime) * Speed;

        float LFractionOfDistance = LTrackDistanceTraveled / LTrackLength;

        transform.position = Vector3.Lerp(LOrigin.position, LDestination.position, LFractionOfDistance);
    }

    private void RNoteMovement()
    {
        float RTrackDistanceTraveled = (Time.time - startTime) * Speed;

        float RFractionOfDistance = RTrackDistanceTraveled / RTrackLength;

        //Instantiate(LNotes, LOrigin);

        transform.position = Vector3.Lerp(ROrigin.position, RDestination.position, RFractionOfDistance);
    }
}