using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*
Mustra y actualiza la cantidad de llaves agarradas.
Contiene una variable "puntos" que se actualiza en algún momento del juego y una variable "textoPuntos" que representa 
el objeto de texto en la pantalla donde se mostrarán el total de llaves. El método "Update" actualiza
el texto en "textoPuntos" para que coincida con el valor actual de "puntos".
*/
public class Puntos : MonoBehaviour
{
   public int puntos;
   public Text textoPuntos;

   private void Update ()
   {
    textoPuntos.text = puntos.ToString();
   } 

}
