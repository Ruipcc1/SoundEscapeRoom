using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public CodeManager script;
    bool repeat;
    // Start is called before the first frame update
    void Start()
    {
        repeat = false;
        GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (repeat == false) {
            if (script.playing == true)
            {
                GetComponent<AudioSource>().Stop();
                StartCoroutine(Wait());
            }
        }
    }

    IEnumerator Wait()
    {
        repeat = true;
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
        repeat = false;
    }

    IEnumerator Win()
    {
        yield return new WaitForSeconds(60);
            script.Input = "";
        GetComponent<AudioSource>().Play();
        script.winning = false;
    }
}
