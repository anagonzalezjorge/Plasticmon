using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    InputPersonaje input;
    /*AGJ - Acceder al collider y modificarlo según el movimiento pulsado*/
    BoxCollider bodyCollider;
    /*AGJ - Referencia para poder aplicar la fuerza para moverlo o que salte*/
    Rigidbody rigidBody;                  //Componente rigidbody

    public float velocidad;				//Velocidad del jugador
    public float FuerzaSalto;

    int direction = 1;

    // Start is called before the first frame update
    void Start()
    {
        input = GetComponent<InputPersonaje>();
        rigidBody = GetComponent<Rigidbody>();
        bodyCollider = GetComponent<BoxCollider>();
    }

    private void Update()
    {
        MovimientoEnSuelo();
        MovimientoEnAire();
    }

    void MovimientoEnSuelo()
    {
        //Calcul la velocidad basada en los inputs
          float xVelocity = velocidad * input.horizontal;

        //AGJ - Guarda la velocidad en el componente RigidBody del personaje
         rigidBody.velocity = new Vector3(xVelocity, rigidBody.velocity.y, 0f);

        if (xVelocity * direction < 0f)
            FlipCharacterDirection();//AGJ - Dar la vuelta al personaje
    }

    void MovimientoEnAire()
    {
     if (Input.GetButtonDown("Jump"))
			{
				rigidBody.AddForce( Vector3.up*FuerzaSalto, ForceMode.Impulse);
				return;
			}
    }

    void FlipCharacterDirection()
    /*AGJ - Da la vuelta al personaje*/
    {
        Vector3 Rotacion = new Vector3(0, 180, 0);
        //Turn the character by flipping the direction
        direction *= -1;

        transform.Rotate(Rotacion);
    }
}
