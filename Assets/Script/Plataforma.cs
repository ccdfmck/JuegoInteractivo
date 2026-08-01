using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Plataforma : MonoBehaviour
{
    public Transform posicionArriba;
    public Transform posicionAbajo;

    public float velocidad = 3f;

    private Vector3 objetivo;

    void Start()
    {
        objetivo = posicionArriba.position;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(
            transform.position,
            objetivo,
            velocidad * Time.deltaTime
        );
    }


    public void Bajar()
    {
        objetivo = posicionAbajo.position;
    }


    public void Subir()
    {
        objetivo = posicionArriba.position;
    }
}
