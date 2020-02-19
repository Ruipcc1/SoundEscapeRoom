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
        winning = false;
        code = "12";
        Input = "";
    }

    // Update is called once per frame
    void Update()
    {
        if(winning == false) {
            if (Input == code)
            {
                winning = true;
                GetComponent<AudioSource>().Play();
                StartCoroutine(Wait());
            }
        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(5);
        GetComponent<AudioSource>().Play();
        if (winning == true)
        {
            StartCoroutine(Wait());
        }
    }
}
