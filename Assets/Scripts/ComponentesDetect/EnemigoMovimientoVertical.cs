using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoMovimientoVertical : MonoBehaviour
{
    private float direccion;
    private float Velocidad;
    private Rigidbody2D rb;
    public AudioSource pum;
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        direccion = -1f;
        Velocidad = 3f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Wall>())
        {
            direccion *= -1f;
        }
        if (collision.GetComponent<Disparo>())
        {
            pum.Play();
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        
        rb.velocity = new Vector3(rb.velocity.x, direccion * Velocidad);
    }
}
