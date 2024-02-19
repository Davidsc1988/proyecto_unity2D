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

        // Cambia la dirección si detecta algún límite (puedes ajustar esto según tu nivel)
    }

    // Método para cambiar la dirección del movimiento
    public void ChangeDirection()
    {
        movingRight = !movingRight;
    }
}
