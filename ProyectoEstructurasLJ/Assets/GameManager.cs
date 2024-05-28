using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int PuntosTotales{ get { return puntosTotales; } }
    private int puntosTotales;
    private int puntosPorTiempo;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SumarPuntos(int puntosASumar)
    {
        puntosTotales += puntosASumar;
        Debug.Log(puntosTotales);     
    }

    public int CalcularPuntosPorTiempo(float tiempo)
    {
        if (tiempo < 2 * 60) // menos de 2 minutos
        {
            return 10000;
        }
        else if (tiempo < 3 * 60) // menos de 3 minutos
        {
            return 7000;
        }
        else if (tiempo < 4 * 60) // menos de 4 minutos
        {
            return 6000;
        }
        else if (tiempo < 5 * 60) // menos de 5 minutos
        {
            return 5000;
        }
        else
        {
            return 0;
        }
    }

    public int PuntajeTotal()
    {
        return puntosTotales + puntosPorTiempo;
    }
   
}
