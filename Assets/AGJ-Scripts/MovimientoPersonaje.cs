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

    float jumpTime;                         //Variable to hold jump duration
    float coyoteTime;                       //Variable to hold coyote duration
    float playerHeight;                     //Height of the player
  
    /*AGJ - originalXScale guarda la escala en X original, para saber
                                             *si está mirando a la derecha o a la izquierda*/
    float originalXScale;                   //Original scale on X axis
    int direction = 1;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
