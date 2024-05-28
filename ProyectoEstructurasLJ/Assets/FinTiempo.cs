using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinTiempo : MonoBehaviour
{

    public Text puntajeTotalText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Timer.instanciar.FinTiempo();
            int puntosPorTiempo = GameManager.instance.CalcularPuntosPorTiempo(Timer.instanciar.tiempoTrans);
            GameManager.instance.SumarPuntos(puntosPorTiempo);
            int puntajeTotal = GameManager.instance.PuntajeTotal();
            puntajeTotalText.text = "Puntaje Total: " + puntajeTotal;
        }
    }
}
