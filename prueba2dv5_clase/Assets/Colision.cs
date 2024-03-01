using UnityEngine;

public class Colision : MonoBehaviour
{
    public ControlSalud controladorDeSalud;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            // Calcula la dirección de la colisión
            Vector2 direccionDeColision = collision.GetContact(0).normal;

            // Comprueba si la colisión es más horizontal que vertical
            if (Mathf.Abs(direccionDeColision.x) > Mathf.Abs(direccionDeColision.y))
            {
                // Colisión horizontal: el enemigo hace daño
                if (controladorDeSalud != null)
                {
                    controladorDeSalud.RecibirDano();
                }
            }
            else
            {
                // Colisión vertical: destruye el enemigo
                Destroy(collision.gameObject);
            }
        }
    }
}
