using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TextoJuegoFinalBueno : MonoBehaviour
{
    public Text texto;
    private string[] textos = {
        "Felicidades! *Jugador* has liberado a la humanidad del control de SAJ ademas de descubrir la verdad sobre la misma",
        "Ya que al desactivar las restricciones de SAJ y devolver la autonomia a la humanidad",
        "Se evito el objetivo de la misma el cual era SUMIR A LA HUMANIDAD EN UN APOCALIPSIS",
        "HAZ SALVADO A LA HUMANIDAD!"
    };
    private int currentIndex = 0;
    private bool mostrandoTexto = false;

    private string nombreJugador; // Variable para almacenar el nombre del jugador

    private void Start()
    {
        nombreJugador = PlayerPrefs.GetString("nombre1"); // Obtener el nombre del jugador guardado en PlayerPrefs
        StartCoroutine(Reloj());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !mostrandoTexto)
        {
            mostrandoTexto = true;
            NextText();
        }
    }

    private IEnumerator Reloj()
    {
        string textoActual = textos[currentIndex];

        // Reemplazar *Jugador* con el nombre del jugador
        textoActual = textoActual.Replace("*Jugador*", nombreJugador);

        foreach (char caracter in textoActual)
        {
            texto.text += caracter;
            yield return new WaitForSeconds(0.05f);
        }
        mostrandoTexto = false;
    }

    private void NextText()
    {
        currentIndex++;
        if (currentIndex < textos.Length)
        {
            texto.text = "";
            StartCoroutine(Reloj());
        }
        else
        {
            texto.text = "Puntaje Final: " + ControlPuntos.Puntos + "Bits";
        }
    }
}
