using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeManager : MonoBehaviour
{
    string code;
    public bool playing;
    public bool winning;
    public string Input;
    // Start is called before the first frame update
    void Start()
    {
        code = "123";
        Input = "";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input == code)
        {
            winning = true;
            GetComponent<AudioSource>().Play();
        }
    }
}
