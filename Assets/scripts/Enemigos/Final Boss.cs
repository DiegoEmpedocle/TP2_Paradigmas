using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalBoss : enemigo
{
    protected new int Health = 20;
    protected GameObject proyectilPrefab;
    protected Transform proyectilSpawn;
    protected float cadencia = 1f;

    protected override void Atacar()
    {
        //ataca disparando hacia el jugador y saltando encima de el
    }

    protected override void Move()
    {
        //se mueve de izquierda a derecha en el aire
    }
}
