using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // El objetivo que la cámara seguirá (tu personaje)
    public float smoothing = 5f; // La velocidad con la que la cámara seguirá al personaje

    Vector3 offset; // Distancia entre la cámara y el personaje

    void Start()
    {
        // Calcula la distancia inicial entre la cámara y el personaje
        offset = transform.position - target.position;
    }

    void FixedUpdate()
    {
        // La nueva posición de la cámara es la posición del personaje más el desplazamiento inicial
        Vector3 targetCamPos = target.position + offset;

        // Suavemente interpola la posición de la cámara entre su posición actual y la nueva posición
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
    }
}
