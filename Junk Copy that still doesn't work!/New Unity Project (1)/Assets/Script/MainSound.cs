using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this is on the Play gameobject

public class MainSound : MonoBehaviour
{
    private AudioSource audioSource; //the song to start with
    public InputManagerScript script;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (script.playing == true)
        {
            GetComponent<AudioSource>().Stop();
            StartCoroutine(Wait());
        }
    }

    IEnumerator Wait() {
        yield return new WaitForSeconds(10);
        script.Input = "";
        if (script.playing == false)
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
