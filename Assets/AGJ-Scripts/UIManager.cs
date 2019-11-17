using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    /* AGJ - Utiliza patron Singlenton*/
    static UIManager current;
    public TextMeshProUGUI numItems;
    
    void Awake()
    {
        //If an UIManager exists and it is not this...
        if (current != null && current != this)
        {
            //...destroy this and exit. There can be only one UIManager
            Destroy(gameObject);
            return;
        }
      
        //This is the current UIManager and it should persist between scene loads
        current = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        
    }

    public static void ActNumItemsUI(int itemCont)
    {
        //If there is no current UIManager, exit
        if (current == null)
            return;

        //Actualiza con el número de items
        current.numItems.text = itemCont.ToString();
    }

}
