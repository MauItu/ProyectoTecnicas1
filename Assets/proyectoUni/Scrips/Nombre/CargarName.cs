using UnityEngine;
using UnityEngine.UI;

public class CargarName : MonoBehaviour
{
    public Text nombreText;

    void Start()
    {
        string nombreGuardado = PlayerPrefs.GetString("nombre1");
        if (!string.IsNullOrEmpty(nombreGuardado))
        {
            nombreText.text = nombreGuardado;
        }
    }
}
