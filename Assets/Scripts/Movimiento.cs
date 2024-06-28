using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movimiento : MonoBehaviour
{
    private float speed = 1f;
    private float antiSpeed = -1f;
    private float RotationSpeed = 75f;
    public GameObject character;
    Rigidbody2D Rigidbody2D;

    Animator animator;


    void Awake()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        
    }


    private void FixedUpdate()
    {
        
        
        if (Input.GetKey(KeyCode.W))
        {
            Rigidbody2D.AddForce(transform.up * speed, ForceMode2D.Impulse);
            animator.SetBool("HaciaAdelante", true);
        }
        else
        {
            animator.SetBool("HaciaAdelante", false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            Rigidbody2D.AddForce(transform.up * antiSpeed, ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * RotationSpeed * Time.deltaTime);
            animator.SetBool("HaciaIzquierda", true);
        }
        else
        {
            animator.SetBool("HaciaIzquierda",false);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.back * RotationSpeed * Time.deltaTime);
            animator.SetBool("HaciaDerecha", true) ;
        }
        else
        {
            animator.SetBool("HaciaDerecha", false) ;
        }
    }

}
