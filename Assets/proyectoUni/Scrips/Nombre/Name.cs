using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Name : MonoBehaviour
{
    public InputField inputText;
    public Text textoNombre;
    public Image luz;
    public GameObject BotonAceptar;

    public void Awake()
    {
        luz.color = Color.red;
    }

    public void Update()
    {
        if (textoNombre.text.Length < 3 || textoNombre.text.Length > 11)
        {
            luz.color = Color.red;
            BotonAceptar.SetActive(false);
        }
        else
        {
            luz.color = Color.green;
            BotonAceptar.SetActive(true);
        }
    }

    public void aceptar()
    {
        if (textoNombre.text.Length >= 3 && textoNombre.text.Length <= 11)
        {
            PlayerPrefs.SetString("nombre1", textoNombre.text);
            SceneManager.LoadScene("Introduccion");
        }
    }
}
