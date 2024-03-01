using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    // Este m�todo se llama cuando otro objeto entra en el trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verifica si el objeto que colision� con la meta tiene la etiqueta "Player"
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Has alcanzado el checkpoint");
        }
    }
}
