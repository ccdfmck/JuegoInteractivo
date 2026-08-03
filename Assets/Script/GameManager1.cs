using UnityEngine;

public class GameManager1 : MonoBehaviour
{
    public PlayerMovement jugador;
    public ArrastrarEstante[] estantes;

    public void EmpezarJuego()
    {
        Debug.Log("SE PRESIONÓ EL BOTÓN");

        jugador.ActivarMovimiento();

        foreach (ArrastrarEstante estante in estantes)
        {
            if (estante != null)
            {
                estante.enabled = false;
            }
        }
    }
}