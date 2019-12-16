using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    //LA CLASE WEAPON LLAMARÁ A LOS DOS MÉTODOS DE DISPARAR Y RECARGAR. ESTOS MÉTODOS LOS HARÁN TODAS LAS ARMAS INDEPENDIENTEMENTE DEL TIPO QUE SEA.
    public abstract void Shoot();
    public abstract void recargar();
}


