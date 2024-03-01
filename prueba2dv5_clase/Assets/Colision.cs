using UnityEngine;

public class Colision : MonoBehaviour
{
    public ControlSalud controladorDeSalud;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            // Calcula la direcci�n de la colisi�n
            Vector2 direccionDeColision = collision.GetContact(0).normal;

            // Comprueba si la colisi�n es m�s horizontal que vertical
            if (Mathf.Abs(direccionDeColision.x) > Mathf.Abs(direccionDeColision.y))
            {
                // Colisi�n horizontal: el enemigo hace da�o
                if (controladorDeSalud != null)
                {
                    controladorDeSalud.RecibirDano();
                }
            }
            else
            {
                // Colisi�n vertical: destruye el enemigo
                Destroy(collision.gameObject);
            }
        }
    }
}
