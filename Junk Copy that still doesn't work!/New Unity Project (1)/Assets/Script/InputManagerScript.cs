using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManagerScript : MonoBehaviour
{
    public string Input; //The current code that has been input
    public bool playing; //If anything is playing
    private AudioSource audioSource;
    private string finalCode; //list of Vuforia Objects expected

    // Start is called before the first frame update
    void Start()
    {
        Input = "";
        audioSource = GetComponent<AudioSource>();
        playing = false;
        finalCode = "123";
    }

    // Update is called once per frame
    void Update()
    {
        // Checks to see if the objects and the 
        if(Input == finalCode)
        {
            GetComponent<AudioSource>().Play(); //should play winning sound "Harambe"
        }
    }
}
