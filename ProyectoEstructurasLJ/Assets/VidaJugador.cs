using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class VidaJugador : MonoBehaviour
{
    [SerializeField] int vida;
    [SerializeField] int maximoVida;
    public event EventHandler MuerteJugador;

    public void Start()
    {
        vida = maximoVida;
    }

    public void TomarDaño(int daño)
    {
        vida -= daño;

        if(vida <= 0)
        {
            MuerteJugador?.Invoke(this, EventArgs.Empty);
            Destroy(gameObject);
        }
    }
}
