using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MuerteYVictoria : MonoBehaviour
{
    public bool Muerto = false;
    public GameObject PantallaMuerte;
    public GameObject PantallaVictoria;
    
    void Start()
    {
        PantallaVictoria.gameObject.SetActive(false);
        PantallaMuerte.gameObject.SetActive(false);
        Time.timeScale = 1.0f;
    }

    
    void Update()
    {
      if (Muerto == true)
        {
            PantallaMuerte.gameObject.SetActive (true);
            Time.timeScale = 0f;
        }  
      
    }

    public void BotonMuerte()
    {
        SceneManager.LoadScene("Menu");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<EnemigoEstatico>())
        {
            Muerto = true;
        }
        if (collision.GetComponent<EnemigoMovimiento>())
        {
            Muerto = true;
        }
        if (collision.GetComponent<EnemigoMovimientoVertical>())
        {
            Muerto = true;
        }
        if (collision.GetComponent<Ganar>())
        {
            PantallaVictoria.gameObject.SetActive(true);
        }
    }
}
