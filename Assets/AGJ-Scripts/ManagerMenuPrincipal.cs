using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManagerMenuPrincipal : MonoBehaviour
{
    [SerializeField]
    private string sceneName;

    public void ButtonStart()
    {
        SceneManager.LoadScene(sceneName);
    }


}
