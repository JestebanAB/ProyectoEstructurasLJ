using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salir : MonoBehaviour
{
    public void Cerrar()
    {
        Debug.Log("Cerrando Juego:");
        Application.Quit();
    }
}
