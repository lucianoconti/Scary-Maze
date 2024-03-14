using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
Sirve para controlar la apertura de la puerta. 
La puerta requiere un cierto número de llaves para abrirse, y el script utiliza 
una variable estática de la clase "Data.keys" para controlar cuántas llaves ha recogido el jugador. 
Cuando el número de llaves recogidas es 5, la puerta se destruye.
*/
public class Door : MonoBehaviour
{
    public int keys;

    void Start(){
        Data.keys=0;
    }
    void Update(){
         keys = Data.keys;
         if(Data.keys >= 5){

          Destroy(gameObject,0.1f);
          
      }
    }
}
