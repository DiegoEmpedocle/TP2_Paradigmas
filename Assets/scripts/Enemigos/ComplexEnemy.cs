using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComplexEnemy : enemigo
{
    protected GameObject proyectilPrefab;
    protected Transform proyectilSpawn;
    protected float cadencia = 1f;
    //protected new float speed = 0f;

    protected override void Atacar()
    {
        //ataca disparando proyectiles en 3/2 direcciones
    }

    protected override void Move()
    {
        //codigo para que no se mueva el enemigo
    }


}
