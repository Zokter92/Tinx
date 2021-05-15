using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CH_Mov : MonoBehaviour
{
    //Variable global
    public float JumpForce;
    public float Speed;

    //Declaracion de variables
    private Rigidbody2D Rigidbody2D;
   // private Animator Animator;
    private float Horizontal;
    private bool Grounded;
    //Void para cuando inicie el Level_1
    void Start()
    {
        //Tomando el componente "Rigidbody2D" de nuestro GameObjet Main_CH
        Rigidbody2D = GetComponent<Rigidbody2D>();
       // Animator.GetComponent<Animator>();
    }
    //Void para cuando este haciendose update (Frame Rate) el Level_1
    void Update()
    {
        //Saber si Horizontal es -1 O 1,, Al ser -1 Es Izquierda,, al Ser 1 Es Derecha
        Horizontal = Input.GetAxisRaw("Horizontal");
        //
        if (Horizontal < 0.0f) transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
        else if (Horizontal > 0.0f) transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        //Animator
        //Animator.SetBool("runing", Horizontal != 0.0f);
        //Debug para el Rawycast
        Debug.DrawRay(transform.position, Vector3.down * 0.18f, Color.red);
        //Comprobando si el personaje toca el suelo para que pueda saltar
        if (Physics2D.Raycast(transform.position, Vector3.down, 0.18f))
        {
            Grounded = true;
        }
        else Grounded = false; 
        //Realizar salto si se preciona Spacio
        if (Input.GetKeyDown(KeyCode.Space) && Grounded)
        {
            //Se crea una funcion para poder tomar Vector2 para la fuerza.
            Jump();
        }
    }
    //Void para darle fuerza al salto. 
    private void Jump()
    {
        Rigidbody2D.AddForce(Vector2.up * JumpForce);
    }
    //Poniendo velocidad al personaje ---Solamente en X "Horizontal", la Y se queda sin movimiento Constante/Velocidad
    private void FixedUpdate()
    {
        Rigidbody2D.velocity = new Vector2(Horizontal, Rigidbody2D.velocity.y);
    }
}
