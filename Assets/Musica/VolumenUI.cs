using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumenUI : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider master;
    public Slider SFX;
    public Slider Music;

    void SetSliders()
    {
        master.value = PlayerPrefs.GetFloat("MasterVolume");
        SFX.value = PlayerPrefs.GetFloat("SFXVolume");
        Music.value = PlayerPrefs.GetFloat("MusicVolume");
    }

    void Start()
    {
      if (PlayerPrefs.HasKey("MasterVolume"))
        {
            mixer.SetFloat("MasterVolume", PlayerPrefs.GetFloat("MasterVolume"));
            mixer.SetFloat("SFXVolume", PlayerPrefs.GetFloat("SFXVolume"));
            mixer.SetFloat("MusicVolume", PlayerPrefs.GetFloat("MusicVolume"));
        }  
      else
        {
            SetSliders();
        }
    }

    public void UpdateMasterVolume()
    {
        mixer.SetFloat("MasterVolume", master.value);
        PlayerPrefs.SetFloat("MasterVolume", master.value);
    }
    public void UpdateSFXVolume()
    {
        mixer.SetFloat("SFXVolume", SFX.value);
        PlayerPrefs.SetFloat("SFXVolume", SFX.value);
    }
    public void UpdateMusicVolume()
    {
        mixer.SetFloat("MusicVolume", Music.value);
        PlayerPrefs.SetFloat("MusicVolume", Music.value);
    }
}
