using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llave : MonoBehaviour

{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.instancia.tieneLlave = true;

            Destroy(gameObject);

            Debug.Log("Llave obtenida");
        }
    }
}