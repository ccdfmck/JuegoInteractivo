using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    public static GameManager instancia;

    public bool tieneLlave = false;

    void Awake()
    {
        instancia = this;
    }
}