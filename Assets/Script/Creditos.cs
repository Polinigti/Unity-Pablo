using UnityEngine;
using UnityEngine.SceneManagement;

public class Creditos : MonoBehaviour
{
    
    public void VueltaMenu(string escena)
    {
        SceneManager.LoadScene(escena);
    }

}
