using UnityEngine;

public class Colision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemigo")) 
        {
            Destroy(collision.gameObject); 
        }
    }

}



