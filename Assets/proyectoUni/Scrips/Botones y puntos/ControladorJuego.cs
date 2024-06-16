using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorJuego : MonoBehaviour
{
    public void EvaluarPuntosYCambiarEscena(int puntos)
    {
        if (puntos >= 30)
        {
            SceneManager.LoadScene("FinalBueno");
        }
        else
        {
            SceneManager.LoadScene("FinalMalo");
        }
    }

    public void ReiniciarPuntosYCambiarEscena(string nombreNivel)
    {
        ControlPuntos.ReiniciarPuntos();
        SceneManager.LoadScene(nombreNivel);
    }
    public void CargarScena(string nombreNivel)
    {
        SceneManager.LoadScene(nombreNivel);
    }
}
