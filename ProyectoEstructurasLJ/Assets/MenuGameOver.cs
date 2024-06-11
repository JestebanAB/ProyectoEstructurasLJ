using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class MenuGameOver : MonoBehaviour
{
    [SerializeField] private GameObject menuGameOver;
    private VidaJugador combateJugador;

    private void Start()
    {
        combateJugador = GameObject.FindGameObjectWithTag("Player").GetComponent<VidaJugador>();
        combateJugador.MuerteJugador += ActivarMenu;
    }

    private void ActivarMenu(object sender, EventArgs e)
    {
        menuGameOver.SetActive(true);
        Time.timeScale = 0; // Pausa el juego
    }

    public void Reiniciar()
    {
        Time.timeScale = 1; // Reanuda el juego
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
    public void MenuInicial(string nombre)
    {
        Time.timeScale = 1; // Reanuda el juego
        SceneManager.LoadScene(nombre);
    }
}
