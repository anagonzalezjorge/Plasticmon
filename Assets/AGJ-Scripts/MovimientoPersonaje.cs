using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    InputPersonaje input;                     
    /*AGJ - Acceder al collider y modificarlo según el movimiento pulsado*/
    BoxCollider2D bodyCollider;             //The collider component
    /*AGJ - Referencia para poder aplicar la fuerza par amoverlo o que salte*/
    Rigidbody2D rigidBody;                  //The rigidbody component

    public float speed = 8f;				//Velocidad del jugador

    // Start is called before the first frame update
    void Start()
    {
        input = GetComponent<InputPersonaje>();
        rigidBody = GetComponent<Rigidbody2D>();
        bodyCollider = GetComponent<BoxCollider2D>();
    }

    private void FixedUpdate()
    {
        MovimientoEnSuelo();
    }

    void MovimientoEnSuelo()
    {
        //Calcul la velocidad basada en los inputs
        float xVelocity = speed * input.horizontal;
        //AGJ - Guarda la velocidad en el componente RigidBody del personaje
        rigidBody.velocity = new Vector2(xVelocity, rigidBody.velocity.y);
    }
}
