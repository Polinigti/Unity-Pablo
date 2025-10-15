using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Creditos()
    {
        Debug.Log("Juego creado por Pablo Gutiérrez Cumplido");
    }

    public void Salir()
    {
        Application.Quit();
        Debug.Log("Juego cerrado");
    }
}

