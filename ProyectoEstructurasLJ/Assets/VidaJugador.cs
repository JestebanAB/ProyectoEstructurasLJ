using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaJugador : MonoBehaviour
{
    [SerializeField] int vida;
    [SerializeField] int maximoVida;

    public void Start()
    {
        vida = maximoVida;
    }

    public void TomarDaño(int daño)
    {
        vida -= daño;

        if(vida <= 0)
        {
            Destroy(gameObject);
        }
    }
}
