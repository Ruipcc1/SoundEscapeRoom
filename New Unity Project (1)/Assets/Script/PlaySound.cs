using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public CodeManager script;
    public string code;
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
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(10);
        if(script.winning == false)
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
