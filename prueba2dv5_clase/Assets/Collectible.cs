using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int value = 1;
    public AudioClip collectSound; // Arrastra aquí tu clip de sonido en el Inspector
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null) // Si no hay AudioSource, lo agregamos
        {
            audioSource = gameObject.AddComponent<AudioSource>();
            audioSource.clip = collectSound;
            audioSource.playOnAwake = false;
            audioSource.outputAudioMixerGroup = null; // Asegúrate de asignar el grupo de mezclador correcto si es necesario
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            if (gameObject.CompareTag("Frutas"))
            {
                scoreManager.AddFruits(value);
            }
            else if (gameObject.CompareTag("Monedas"))
            {
                scoreManager.AddCoins(value);
            }

            audioSource.Play(); // Reproduce el sonido de recoger el objeto

            // Desactivamos el renderizado y los colliders del objeto
            if (GetComponent<Renderer>() != null)
                GetComponent<Renderer>().enabled = false;

            foreach (Collider2D collider in GetComponents<Collider2D>())
            {
                collider.enabled = false;
            }

            // Inicia la coroutine para destruir el objeto después del sonido
            StartCoroutine(DestroyAfterSound(audioSource.clip.length));
        }
    }

    private IEnumerator DestroyAfterSound(float delay)
    {
        // Restamos un pequeño valor al delay para asegurarnos de que el objeto se destruya justo después de que el sonido termine
        yield return new WaitForSeconds(delay - 0.1f); // Ajusta este valor si es necesario
        Destroy(gameObject);
    }
}