using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour
{
    public float moveSpeed = 2f;
    private bool movingRight = true;

    void Update()
    {
        if (movingRight)
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(-Vector2.right * moveSpeed * Time.deltaTime);
        }

        // Cambia la direcci�n si detecta alg�n l�mite (puedes ajustar esto seg�n tu nivel)
    }

    // M�todo para cambiar la direcci�n del movimiento
    public void ChangeDirection()
    {
        movingRight = !movingRight;
    }
}
