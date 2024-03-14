using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasandoCorrediza : MonoBehaviour
{
   public Animator laPuerta;


   private void OnTriggerEnter(Collider other)
   {
        if(other.tag=="Player"){

            laPuerta.Play("Abrir");
        }
   }
   private void OnTriggerExit(Collider other)
   {
        if(other.tag=="Player"){

            laPuerta.Play("Cerrar");
        }
   }
}
