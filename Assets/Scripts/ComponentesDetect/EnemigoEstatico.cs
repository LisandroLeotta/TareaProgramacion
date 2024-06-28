using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoEstatico : MonoBehaviour
{
    public AudioSource pum;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Disparo>())
        {
            pum.Play();
            Destroy(gameObject);
        }
    }
}
