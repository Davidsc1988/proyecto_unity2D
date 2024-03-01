using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlSalud : MonoBehaviour
{
    public GameObject[] vidas; // Asigna Vida1, Vida2 y Vida3 en el inspector
    private int salud;

    void Start()
    {
        // Inicializa la salud con el número de vidas (corazones)
        salud = vidas.Length;
    }

    public void RecibirDano()
    {
        if (salud > 0)
        {
            salud--; // Reduce la salud
            // Destruye el último corazón activo
            Destroy(vidas[salud].gameObject);

            if (salud <= 0)
            {
                // Si no quedan vidas, reinicia el juego
                Debug.Log("Juego terminado. Reiniciando...");
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
