using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static GameManager current;
    List<ItemBasura> Items;
    bool esFinal;

    void Awake()
    {
        //If a Game Manager exists and this isn't it...
        if (current != null && current != this)
        {
            //...destroy this and exit. There can only be one Game Manager
            Destroy(gameObject);
            return;
        }

        //Set this as the current game manager
        current = this;

        //Create out collection to hold the orbs
        Items = new List<ItemBasura>();

        //Persis this object between scene reloads
        DontDestroyOnLoad(gameObject);
    }


    public static void RegistrarItems(ItemBasura item)
    {
        if (current == null)
            return;

        if (!current.Items.Contains(item))
            current.Items.Add(item);
        //Indicar a la UI el número de items a recoger
        UIManager.ActNumItemsUI(current.Items.Count);

    }

    public static void JugadorRecogeItem (ItemBasura item)
    {
        //If there is no current Game Manager, exit
        if (current == null)
            return;

        //If the orbs collection doesn't have this orb, exit
        if (!current.Items.Contains(item))
            return;
        /* AGJ - Si el personaje recoge un 'item', este método comprueba 
         * que es uno de los definidos en la escena actual. En este caso, 
         * lo elimina. Cuando no queden por recoger, se abre la puerta
         */
        current.Items.Remove(item);


        //If there are no more orbs, tell the door to open
        // if (current.Items.Count == 0)
        //current.lockedDoor.Open();

        //Indica a UIManager actualizar con el número de items
        UIManager.ActNumItemsUI(current.Items.Count);
    }


    public static void JugadorGana()
    {
        //If there is no current Game Manager, exit
        if (current == null)
            return;

        //The game is now over
        current.esFinal = true;

        //Tell UI Manager to show the game over text and tell the Audio Manager to play
        //game over audio
        //UIManager.DisplayGameOverText();
        //AudioManager.PlayWonAudio();
    }

}
