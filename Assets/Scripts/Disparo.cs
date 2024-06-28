using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    
    public float speed = 50f;
    public int damage = 1;

    Rigidbody2D rb;

    private void Awake()
    {
        rb= GetComponent<Rigidbody2D>();
    }


    private void FixedUpdate()
    {
        rb.AddForce(transform.up * speed);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Wall>())
        {
            Destroy(gameObject);
        }
        if (collision.GetComponent<EnemigoEstatico>()) 
        { 
            Destroy(gameObject); 
        }
        if (collision.GetComponent<EnemigoMovimiento>())
        {
            Destroy(gameObject);
        }
        if (collision.GetComponent<EnemigoMovimientoVertical>())
        {
            Destroy(gameObject);
        }
    }
}
