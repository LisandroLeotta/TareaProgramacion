using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SFXPrueba : MonoBehaviour
{
    public AudioSource AudioSource;
    void Start()
    {
       
    }

   public void boton()
    {
        AudioSource.Play();
    }
}
