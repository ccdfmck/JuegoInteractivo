using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class Boton : MonoBehaviour
{
    public Plataforma plataforma;
    public ColumnaMovil columna;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            plataforma.Bajar();
        }

        if (collision.CompareTag("Cube"))
        {
            columna.SubirColumna();
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            plataforma.Subir();
        }

        if (collision.CompareTag("Cube"))
        {
            columna.BajarColumna();
        }
    }
}