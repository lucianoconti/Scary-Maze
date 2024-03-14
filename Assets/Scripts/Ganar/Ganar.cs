using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ganar : MonoBehaviour
{
    public Manejador auxmanejador;

    
    private void OnTriggerEnter (Collider other)
    {
      if(other.tag=="Salida")
      {
        
        Debug.Log("hola");
        auxmanejador.ActivarMenuVictoria2();
        Time.timeScale=0;
      }
    }        

}
