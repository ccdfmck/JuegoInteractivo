using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Boton : MonoBehaviour
{
    public Plataforma plataforma;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            plataforma.Bajar();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            plataforma.Subir();
        }
    }
}