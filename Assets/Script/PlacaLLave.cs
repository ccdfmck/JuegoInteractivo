using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlacaLlave : MonoBehaviour
{
    public GameObject llave;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            llave.SetActive(true);
        }
    }
}