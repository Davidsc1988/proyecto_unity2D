using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    // Funci�n para reiniciar el juego y jugar de nuevo
    public void JugardeNuevo()
    {
        // Carga la escena donde el juego comienza. Aseg�rate de que el �ndice de la escena 
        SceneManager.LoadScene("EscenaJuego");
    }

    // Funci�n para cargar el men� principal
    public void VolverMenu()
    {
        SceneManager.LoadScene("MenuInicial");
    }
}