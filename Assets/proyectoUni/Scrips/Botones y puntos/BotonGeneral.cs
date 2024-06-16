using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonGeneral : MonoBehaviour
{
    
    public ControladorJuego controlador;

    public bool ReiniciarPuntaje;
    public bool EsPreguntaFinal;
    public void CargarNivel(string nombreNivel)
    {
        ControlPuntos.IncrementarPuntos(0);
        
        if(EsPreguntaFinal)
        {
            controlador.EvaluarPuntosYCambiarEscena(ControlPuntos.Puntos);
        }

        else if(ReiniciarPuntaje)
        {
            controlador.ReiniciarPuntosYCambiarEscena(nombreNivel);
        }
        else
        {
            //Muestralacantidad de puntos en consola
            Debug.Log(ControlPuntos.Puntos);
            controlador.CargarScena(nombreNivel);
        }
        

    }
}