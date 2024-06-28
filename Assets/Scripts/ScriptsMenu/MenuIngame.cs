using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuIngame : MonoBehaviour
{
    public GameObject Menu;
    public GameObject Menuexterior;
    public GameObject Menuinterior;
    public bool EnMenu = false;
    public MuerteYVictoria contenedor;
    void Start()
    {
        
        Menuinterior.gameObject.SetActive(false);
        Menuexterior.gameObject.SetActive(false);
        
    }

    public void Update()
    {
        
            if (Input.GetKeyDown(KeyCode.Escape) && EnMenu == false && contenedor.Muerto == false)
            {
                EnMenu = true;
                
                Menuinterior.gameObject.SetActive(false);
                Menuexterior.gameObject.SetActive(true);
                Time.timeScale = 0f;
            }
            else if (Input.GetKeyDown(KeyCode.Escape) && EnMenu == true & contenedor.Muerto == false)
            {
                EnMenu = false;
                
                Menuinterior.gameObject.SetActive(false);
                Menuexterior.SetActive(false); 
                Time.timeScale = 1f;
            }
        
        
    }
    public void BotonVolver()
    {
        Menu.gameObject.SetActive(false);
        EnMenu = false;
        Time.timeScale = 1f;
    }
    public void BotonSonido()
    {
        Menuinterior.gameObject.SetActive(true);
        Menuexterior.gameObject.SetActive(false);
    }

    public void BotonPrincipal()
    {
        SceneManager.LoadScene("Menu");
        EnMenu = false ;
        Time.timeScale = 1f;
    }

    public void BotonSonidoVolver()
    {
        Menuinterior.gameObject.SetActive(false);
        Menuexterior.gameObject.SetActive(true);
    }
}
