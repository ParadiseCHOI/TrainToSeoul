using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundSetting : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider volume;

    void Start()
    {
        volume.value = PlayerPrefs.GetFloat("MusicVolume", 1f);
    }

    public void SetLevel(){
        float sliderValue = volume.value;
        mixer.SetFloat("MusicVol", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("MusicVolume", sliderValue);
    }
}