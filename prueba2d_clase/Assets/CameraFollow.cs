using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // El objetivo que la c�mara seguir� (tu personaje)
    public float smoothing = 5f; // La velocidad con la que la c�mara seguir� al personaje

    Vector3 offset; // Distancia entre la c�mara y el personaje

    void Start()
    {
        // Calcula la distancia inicial entre la c�mara y el personaje
        offset = transform.position - target.position;
    }

    void FixedUpdate()
    {
        // La nueva posici�n de la c�mara es la posici�n del personaje m�s el desplazamiento inicial
        Vector3 targetCamPos = target.position + offset;

        // Suavemente interpola la posici�n de la c�mara entre su posici�n actual y la nueva posici�n
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
    }
}
