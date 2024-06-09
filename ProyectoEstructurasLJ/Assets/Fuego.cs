using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuego : MonoBehaviour
{

    [SerializeField] private float tiempoEntreDaño;
    private float tiempoSiguienteDaño;

    private void OnTriggerStray2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            tiempoSiguienteDaño -= Time.deltaTime;

            if(tiempoSiguienteDaño <= 0)
            {
                other.GetComponent<VidaJugador>().TomarDaño(5);
                tiempoSiguienteDaño = tiempoEntreDaño;
            }   
            
        }
        
    }
    
}
