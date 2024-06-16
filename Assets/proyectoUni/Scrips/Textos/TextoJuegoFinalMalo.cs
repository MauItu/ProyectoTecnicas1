using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TextoJuegoFinalMalo : MonoBehaviour
{
    public Text texto;
   private string[] textos = {
        "Ha ocurrido un grave error.... ",
        "SAJ se dio cuenta de la encriptacion a la que estaba siendo sometido y fuiste encontrado en su base de datos....",
        "Tras haber sido encontrado en su red neuronal SAJ ha desaparecido cada rastro tuyo incluida tu propia existencia....",
        "SAJ al toparse con el peligro de que un usuario de su red estuvo a punto de finiquitarlo decidio no tomar riesgos y efectuo el protocolo AXPH-2100",
        "Activando de esa forma el sistema de autodestruccion y acabar de este modo con todo rastro de vida humana en el mundo...."
    };
    private int currentIndex = 0;
    private bool mostrandoTexto = false;

    private void Start()
    {
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
        foreach (char caracter in textos[currentIndex])
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
