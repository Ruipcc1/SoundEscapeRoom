using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public CodeManager script;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(script.playing == true)
        {
            GetComponent<AudioSource>().Stop();
            StartCoroutine(Wait());
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(10);
        if(script.winning == false)
        {
            GetComponent<AudioSource>().Play();
            script.Input = "";
        }
        else if (script.winning == true)
        {
            StartCoroutine(Win());
        }
    }

    IEnumerator Win()
    {
        yield return new WaitForSeconds(60);
            script.Input = "";
        GetComponent<AudioSource>().Play();

    }
}
