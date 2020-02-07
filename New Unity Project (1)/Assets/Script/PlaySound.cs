using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioClip sound;
    private AudioSource audioSource;
    public ImageTargetPlayAudio script;
    public string code;
    // Start is called before the first frame update
    void Start()
    {
        audioSource.PlayOneShot(sound);
    }

    // Update is called once per frame
    void Update()
    {
        if(script.playing == true)
        {
            GetComponent<AudioSource>().Stop();
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(5);
        if (code == (script.Input))
        {
            GetComponent<AudioSource>().Play();
        }
        else if (code != (script.Input))
        {
            GetComponent<AudioSource>().Play();
        }
        if(script.playing == false)
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
