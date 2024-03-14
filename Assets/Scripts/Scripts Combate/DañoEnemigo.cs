using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoEnemigo : MonoBehaviour
{
    [SerializeField]
    private int daño;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag =="Enemigo")
        {
            other.GetComponent<DatosEnemigo>().vida-=daño;
        }
    }
}
