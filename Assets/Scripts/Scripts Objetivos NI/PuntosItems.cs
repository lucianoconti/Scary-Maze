using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
Suma los "puntos" al objeto que contiene el script "Puntos" 
cuando un objeto colisiona con el jugador . El valor de los puntos que se agregan
se establece en la variable "PuntosQueDa" y se agrega a través del objeto "ObjPuntos" que contiene el script "Puntos".

*/
public class PuntosItems : MonoBehaviour
{
    public GameObject ObjPuntos;
    public int PuntosQueDa; 
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            ObjPuntos.GetComponent<Puntos>().puntos += PuntosQueDa;
        }
    }    
}
