using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ColumnaMovil : MonoBehaviour
{
    public Transform posicionArriba;
    public Transform posicionAbajo;

    public float velocidad = 3f;

    private Vector3 objetivo;


    void Start()
    {
        // La columna empieza abajo
        objetivo = posicionAbajo.position;
    }


    void Update()
    {
        transform.position = Vector3.MoveTowards(
            transform.position,
            objetivo,
            velocidad * Time.deltaTime
        );
    }


    public void SubirColumna()
    {
        objetivo = posicionArriba.position;
    }


    public void BajarColumna()
    {
        objetivo = posicionAbajo.position;
    }
}
