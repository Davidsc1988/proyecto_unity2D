using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meta : MonoBehaviour
{
    // Este método se llama cuando otro objeto entra en el trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verifica si el objeto que colisionó con la meta tiene la etiqueta "Player"
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Alcanzó la meta. Fin del juego");
        }
    }
}