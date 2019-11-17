using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManagerMenuPrincipal : MonoBehaviour
{
    [SerializeField]
    private string sceneName;

    public Button Jugar;
    public Button Atras;
    public Button Salir;

    private void Start()
    {
        Jugar.enabled = true;
        Time.timeScale = 0;
    }

    public void ButtonStart()
    {
        SceneManager.LoadScene(sceneName);
        Time.timeScale = 1;
    }


}
