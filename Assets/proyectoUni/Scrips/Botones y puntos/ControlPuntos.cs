using UnityEngine;

public static class ControlPuntos
{
    private static int puntos = 0;
    
    public static int Puntos
    {
        get
        {
            return puntos;
        }
    }

    public static void IncrementarPuntos(int cantidad)
    {
        puntos += cantidad;
    }

    public static void ReiniciarPuntos()
    {
        puntos = 0;
    }

    
}