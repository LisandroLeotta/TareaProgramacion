using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Device;
using UnityEngine.SceneManagement;

public class MenuCosas : MonoBehaviour
{
    public GameObject Text;
    public GameObject BotonJugar;
    public GameObject BotonOpciones;
    public GameObject BotonAtras;
    public GameObject BotonSalir;
    public GameObject SonidoCosas;
    void Start()
    {
        BotonAtras.gameObject.SetActive(false);
        BotonSalir.gameObject.SetActive(false);
        SonidoCosas.gameObject.SetActive(false);
    }

    public void BotonOpc()
    {
        BotonAtras.gameObject.SetActive(true);
        BotonSalir.gameObject.SetActive(true);
        SonidoCosas.gameObject.SetActive(true);
        BotonJugar.gameObject.SetActive(false);
        BotonOpciones.gameObject.SetActive(false);
        Text.gameObject.SetActive(false);
    }
    public void BotonAtr()
    {
        BotonAtras.gameObject.SetActive(false);
        BotonSalir.gameObject.SetActive(false);
        SonidoCosas.gameObject.SetActive(false);
        BotonJugar.gameObject.SetActive(true);
        BotonOpciones.gameObject.SetActive(true);
        Text.gameObject.SetActive(true);
    }

    public void BotonSal()
    {
        UnityEngine.Application.Quit();
    }

    public void Iniciar()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
