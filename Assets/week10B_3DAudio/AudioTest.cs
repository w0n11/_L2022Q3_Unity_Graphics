using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTest : MonoBehaviour
{
    AudioSource Audio;
    void Start()
    {
        Audio = GetComponent<AudioSource>();
        Audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)){
            Audio.Play();
        }
        if(Input.GetKeyDown(KeyCode.S)){
            Audio.Stop();
        }
    }
}
