using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

//This is on all vuforia Objects and is used when the camera sees an object.

public class ImageTargetPlayAudio : MonoBehaviour, ITrackableEventHandler
{
    private TrackableBehaviour mTrackableBehaviour;
    public InputManagerScript Manager;
    public string number;
    private AudioSource audioSource;

    void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    public void OnTrackableStateChanged(
                                    TrackableBehaviour.Status previousStatus,
                                    TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            // Play audio when target is found
            GetComponent<AudioSource>().Play();
            Manager.playing = true; //tells the InputManagerScript something is playing.
            Manager.Input = Manager.Input + number; //adds the current objects number to the input manager script.
        }
        else
        {
            // Stop audio when target is lost
            GetComponent<AudioSource>().Stop();
            Manager.playing = false;
        }
    }
}
