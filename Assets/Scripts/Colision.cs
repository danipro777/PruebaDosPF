using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Verificar si el objeto colisionado tiene la etiqueta "ObjetoEliminar"
        if (collision.gameObject.CompareTag("Circulo"))
        {
            // Destruir el objeto colisionado
            Destroy(collision.gameObject);
        }
    }
}
