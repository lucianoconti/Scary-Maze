using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
/*
 Utilizamos un objeto Slider para mostrar la cantidad de vida del jugador y se actualiza continuamente 
 en función del valor de vidaJugador. Además, el script contiene eventos que se activan en caso de que la 
 vida del jugador llegue a cero, lo que significa que el jugador muere y se detiene el tiempo en el juego.
*/
public class InfoJugador : MonoBehaviour
{
   public int vidaJugador;
   public Slider VidaSlider;

   public event EventHandler MuerteJugador;
    public event EventHandler VictoriaJugador;


   private void Update()
   {  


      VidaSlider.GetComponent<Slider>().value = vidaJugador;
      if(vidaJugador <=0) 
      {
          MuerteJugador?.Invoke(this, EventArgs.Empty);
          Time.timeScale=0;
      }
   }
}
