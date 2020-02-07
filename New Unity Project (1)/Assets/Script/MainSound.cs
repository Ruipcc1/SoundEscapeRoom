using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSound : MonoBehaviour
{
    private AudioSource audioSource;
    public ImageTargetPlayAudio script;

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
        yield return new WaitForSeconds(5);
        if (script.playing == false)
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
