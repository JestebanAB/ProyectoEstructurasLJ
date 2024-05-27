using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour
{
    public static Timer instanciar;
    public Text Crono;
    private TimeSpan tiempoCrono;
    private bool timerBool;
    private float tiempoTrans;

    private void Awake()
    {
        instanciar = this;
    } 

    private void start()
    {
        Crono.text = "tiempo: 00:00:00";
        timerBool = false;
    }

    public void IniciarTiempo()
    {
        timerBool = true;
        tiempoTrans = 0F; 

        StartCoroutine(ActUpdate());
    }

    public void FinTiempo()
    {
        timerBool = false;        
    }

    private IEnumerator ActUpdate()
    {
        while(timerBool)
        {
            tiempoTrans += Time.deltaTime; 
            tiempoCrono = TimeSpan.FromSeconds(tiempoTrans);
            string tiempoCronoStr = "Tiempo: " + tiempoCrono.ToString("mm':'ss':'ff");
            Crono.text = tiempoCronoStr;

            yield return null;
        }

    }   
}
