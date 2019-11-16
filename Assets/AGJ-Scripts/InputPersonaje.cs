using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPersonaje : MonoBehaviour
{
  
    //AGJ - Variables para almacenar el valorde la tecla pulsada por el jugador

    [HideInInspector] public float horizontal;     
    [HideInInspector] public bool jumpHeld;        
    [HideInInspector] public bool jumpPressed;

    // Start is called before the first frame update
    void Start()
    {
        //AGJ - Procesa los valores de entrada del jugador
        ProcesaInputs();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //AGJ - Acumula las pulsaciones que se realizan entre fotograma y fotograma
    /*Los valores de GetAxis van de -1 a 1:
       -1 tecla horizontal izquierda 
        0 no está pulsando tecla horizontal  
        1 tecla horizontal derecha*/
    void ProcesaInputs()
    {
        horizontal += Input.GetAxis("Horizontal");
    }
    

}
