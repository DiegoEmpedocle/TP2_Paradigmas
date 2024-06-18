using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUp : MonoBehaviour
{
    protected abstract void AppPowerUp(GameObject Player); //aplicaria el powerup al player

    private void OnTriggerEnter( Collider other)
    {
        //si posee tag Player aplica el power up y el power up desaparece
    }
}