using UnityEngine;
using System.Collections;

public class TextBase : MonoBehaviour
{
    [Header("Activar Pregunta")]
    public GameObject FondoNegro;
    public GameObject FondoExpli;
    public GameObject BotonYes;
    public GameObject BotonNo1;


    public void ActivateObject()
    {
        FondoNegro.SetActive(true);
        FondoExpli.SetActive(true);
        BotonYes.SetActive(false);
        BotonNo1.SetActive(true);

    }

    public void DesactivarObject()
    {
        FondoNegro.SetActive(false);
        FondoExpli.SetActive(false);
        BotonYes.SetActive(true);
        BotonNo1.SetActive(false);

    }
}
