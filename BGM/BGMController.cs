using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMController : MonoBehaviour
{
    public AudioClip Night_BGM;
    public AudioClip Day_BGM;

    private AudioSource audio;

    public void night(){
        audio.clip = Night_BGM;
        audio.Play();
    }

    public void day(){
        audio.clip = Day_BGM;
        audio.Play();
    }

    public void stop(){
        audio.Stop();
    }
    public void pause(){
        audio.Pause();
    }

    public void resume(){
        audio.Play();
    }

    void Awake(){
        audio = GetComponent<AudioSource>();
        audio.clip = Day_BGM;
    }
}
