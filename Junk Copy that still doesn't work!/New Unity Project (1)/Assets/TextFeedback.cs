using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFeedback : MonoBehaviour
{
    public Text playingText;
    public MainSound MSs;
    public InputManagerScript IMs;

    // Start is called before the first frame update
    void Start()
    {
        playingText.text = "XXXXXXXXXXXXXX";
    }

    // Update is called once per frame
    void Update()
    {
        if (IMs.playing == true)
        {
            playingText.text = "PLAYING";
        }else
        {
            playingText.text = "NOT PLAYING";
        }
    }
}
