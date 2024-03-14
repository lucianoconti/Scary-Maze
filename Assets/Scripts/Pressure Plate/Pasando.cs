using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
Controla la animación de una puerta cuando un objeto 
o el jugador entran o salen del área de activación. Cuando un objeto o el jugador 
entra en el área, la animación de abrir la puerta se reproduce. Cuando salen del área,
la animación de cerrar la puerta se reproduce. El script utiliza un objeto Animator para
reproducir las animaciones de abrir y cerrar la puerta.
*/

public class Pasando : MonoBehaviour
{
   public Animator laPuerta;


   private void OnTriggerEnter(Collider other)
   {
        if(other.tag=="Player"){

            laPuerta.Play("AbrirElevadiza");
        }else if(other.tag=="Objeto"){
            laPuerta.Play("AbrirElevadiza");
        }
   }
   private void OnTriggerExit(Collider other)
   {
        if(other.tag=="Player"){

            laPuerta.Play("CerrarElevadiza");
        }else if(other.tag=="Objeto"){
            laPuerta.Play("CerrarElevadiza");
        }
   }
}
