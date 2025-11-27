using UnityEngine;
using UnityEngine.SceneManagement;
public class CambiarDeEscena : MonoBehaviour
{
    public void CambiarDeEscenaInicial()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +0);
    }
}
