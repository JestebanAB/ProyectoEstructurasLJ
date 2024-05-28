using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuTrigger : MonoBehaviour
{

   public GameObject scorePanel; // Asegúrate de asignar esto en el Inspector

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Muestra el panel de puntuación
            scorePanel.SetActive(true);
        }
    }
}

