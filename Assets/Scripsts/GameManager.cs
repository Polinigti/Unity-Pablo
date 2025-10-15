using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int totalCubes;
    private int collected = 0;

    void Start()
    {
        totalCubes = GameObject.FindGameObjectsWithTag("Collectible").Length;
    }

    public void AddPoint()
    {
        collected++;
        Debug.Log("Puntos: " + collected + "/" + totalCubes);

        if (collected >= totalCubes)
        {
            NextLevel();
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Nivel1"); 
    }

    
    private void NextLevel()
    {
        string currentScene = SceneManager.GetActiveScene().name;

        if (currentScene == "Level1")
        {
            SceneManager.LoadScene("Level2");
        }
        else if (currentScene == "Level2")
        {
            SceneManager.LoadScene("Victory");
        }
    }
}


