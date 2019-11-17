using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimacionPersonaje : MonoBehaviour
{
    MovimientoPersonaje movement;    //Reference to the PlayerMovement script component
    Rigidbody rigidBody;      //Reference to the Rigidbody2D component
    Animator anim;
    InputPersonaje input;

    /* AGJ - Parámetros para los valores que se envían al componente Animator*/
    
    int velocidadParamID;           //ID of the speed parameter
    int fallParamID;

    public void Start()
    {
        velocidadParamID = Animator.StringToHash("speed");
        fallParamID = Animator.StringToHash("verticalVelocity");

        movement = GetComponent<MovimientoPersonaje>();
        rigidBody = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        /* AGJ - Envía al componente 'Animator' el estado de las variables.
         *       Es decir, en cada fotograma, el método Update() envía al 
         *       componente 'Animator' el valor de cada variable*/
         
        /*AGJ - Velocidad en el eje Y para saber si sube o cae*/
        anim.SetFloat(fallParamID, rigidBody.velocity.y);

        //Use the absolute value of speed so that we only pass in positive numbers
        /*AGJ - Velocidad del personaje, para saber si anda o corre*/
        anim.SetFloat(velocidadParamID, rigidBody.velocity.x);
    }
}
