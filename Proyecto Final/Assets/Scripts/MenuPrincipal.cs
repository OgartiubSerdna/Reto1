using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{

    public void Jugar() 
    {
        SceneManager.LoadScene("World1");
    }

    public void World1()
    {
        SceneManager.LoadScene("World1");
    }

    public void World2()
    {
        SceneManager.LoadScene("World2");
    }

    public void World3()
    {
        SceneManager.LoadScene("World3");
    }

    public void Salir()
    {
        Debug.Log("Babba Boy Menu");
        Application.Quit();
    }
}
