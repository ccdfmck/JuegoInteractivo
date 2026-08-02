using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour

{
    public GameObject pantallaVictoria;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (GameManager.instancia.tieneLlave)
            {
                pantallaVictoria.SetActive(true);
            }
            else
            {
                Debug.Log("Necesitas una llave");
            }
        }
    }
}