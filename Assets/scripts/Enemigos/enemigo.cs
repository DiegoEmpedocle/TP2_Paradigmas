using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class enemigo : MonoBehaviour
{
    protected float speed = 1f;
    protected int damage = 1;
    protected int Health = 2;

    protected abstract void Move();
    protected abstract void Atacar();


    protected void RecibirDaño()
    {
        //codigo recibir daño
    }

    protected void Morir()
    {
        //codigo para morir
    }
}
