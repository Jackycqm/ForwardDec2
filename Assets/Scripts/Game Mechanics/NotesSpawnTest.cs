using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesSpawnTest : MonoBehaviour
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject RightTracks;

    public GameObject LeftTracks;

    public float RightTrackXOffset;
    public float LeftTrackXOffset;

    public float YOffset;

    // This script will simply instantiate the Prefab when the game starts.
    private void Start()
    {
        // Instantiate at position (0, 0, 0) and zero rotation.
        Instantiate(RightTracks, new Vector3(RightTrackXOffset, YOffset, 0), Quaternion.identity);
        Instantiate(LeftTracks, new Vector3(LeftTrackXOffset, YOffset, 0), Quaternion.identity);
    }

    // Update is called once per frame
    private void Update()
    {
    }
}