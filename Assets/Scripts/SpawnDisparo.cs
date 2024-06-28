using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SpawnDisparo : MonoBehaviour
{
    public Transform launchPoint;
    public GameObject disparoPrefab;
    public AudioSource Pium;
    public Transform Triangle;
    public float speed = 5f;
    public MenuIngame MuerteYVictoria;
    public bool disparo = false;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            disparo = true;
        }
    }

    public void FixedUpdate()
    {
        if (disparo == true && MuerteYVictoria.EnMenu == false)
        {
            Pium.Play();
            disparo = false;

            GameObject projectile = Instantiate(disparoPrefab, launchPoint.position, Triangle.transform.rotation);
            projectile.GetComponent<Rigidbody2D>().AddForce(transform.up * speed, ForceMode2D.Impulse);
            
        }
        
        
    }
}
