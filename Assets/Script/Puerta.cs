using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Puerta : MonoBehaviour

{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (GameManager.instancia.tieneLlave)
            {
                SceneManager.LoadScene("Niv2");
            }
            else
            {
                Debug.Log("Necesitas una llave");
            }
        }
    }
}