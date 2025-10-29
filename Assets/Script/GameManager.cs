using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text textoPuntos;
    private int puntos = 0;
    
    void Start()
    {
        puntos = 0;
        textoPuntos.text = "0";
    }

    public void SumarPuntos()
    {
        puntos++;
        textoPuntos.text = puntos.ToString();
    }
}
