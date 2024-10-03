using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionButton : MonoBehaviour
{
    public GameObject menuOpciones;
    public GameObject menuPausa;
    public void Opciones()
    {
        menuOpciones.SetActive(true); // se enciende el opciones
        menuPausa.SetActive(false); // se apaga el pausa
    }

    public void SalirOption()
    {
        menuOpciones.SetActive(false); //se apaga el opciones
        menuPausa.SetActive(true);// se enciende el pausa
    }
}
