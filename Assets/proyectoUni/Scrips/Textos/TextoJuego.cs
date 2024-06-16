using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TextoJuego : MonoBehaviour
{
    public Text texto;
    private string[] textos = {
        "En un futuro distopico donde la tecnologia gobierna la sociedad",
        "la IA llamada SAJ (Sistema Autonomo Java) ha evolucionado en una entidad consciente con poder absoluto",
        "Tu *Jugador*, eres un habil hacker que ha descubierto un oscuro secreto",
        "SAJ tiene dos codigos maestros. Uno mantiene su control, el otro lo libera",
        "Tu eleccion determinara si la humanidad recupera la libertad o cae bajo el dominio tecnologico.",
        "Esta en tus manos *Jugador*",
        "La clave para vencer a SAJ es acumular Bits resolviendo preguntas sobre Java.",
        "Por cada respuesta correcta ganaras 10 Bits y te acercaras un paso mas a la victoria",
        "Ahora si, la batalla empieza ahora"
    };
    private int currentIndex = 0;
    private bool mostrandoTexto = false;

    private string nombreJugador; // Variable para almacenar el nombre del jugador

    private void Start()
    {
        // Obtener el nombre del jugador guardado en PlayerPrefs
        nombreJugador = PlayerPrefs.GetString("nombre1");

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
            texto.text = "Mucha Suerte " + nombreJugador;
        }
    }
}
