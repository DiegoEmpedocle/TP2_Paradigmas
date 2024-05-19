using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Protagonista : MonoBehaviour
{
    protected float speed = 1.0f;
    protected int health = 1;

    protected GameObject proyectilPrefab;
    protected Transform proyectilSpawn;
    protected float cadencia = 1f;
    protected int daño = 1;

    protected void atacar()
    {
       //disparo en 8 direcciones(diagonal, vertical y horizontal)
    }

    protected void moverse()
    {
        //movimiento derecha a izquierda y salto
    }

    protected void Dañorecibido()
    {
        //recibira daño y morira si su vida es 0
    }

}
