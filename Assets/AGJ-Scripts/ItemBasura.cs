using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBasura : MonoBehaviour
{
    int playerLayer;                        //The layer the player game object is on
    
    void Start()
    {
        //Get the integer representation of the "Player" layer
        playerLayer = LayerMask.NameToLayer("Player");

        //Register this orb with the game manager
        GameManager.RegistrarItems(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        //If the collided object isn't on the Player layer, exit. This is more 
        //efficient than string comparisons using Tags
        if (collision.gameObject.layer != playerLayer)
            return;


        //Indica  al audio manager que ha recogido un item de basura
       // AudioManager.PlayItemCollectionAudio();

        //Indica a GameManager que ha recolectado un item de basura.
        GameManager.JugadorRecogeItem(this);

        //Desactiva el item de basura.
        gameObject.SetActive(false);
    }
}
