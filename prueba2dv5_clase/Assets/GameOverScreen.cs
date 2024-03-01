using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    // Función para reiniciar el juego y jugar de nuevo
    public void JugardeNuevo()
    {
        // Carga la escena donde el juego comienza. Asegúrate de que el índice de la escena 
        SceneManager.LoadScene("EscenaJuego");
    }

    // Función para cargar el menú principal
    public void VolverMenu()
    {
        SceneManager.LoadScene("MenuInicial");
    }
}