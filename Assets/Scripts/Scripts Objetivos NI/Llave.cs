using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
Incrementa la variable estática "keys" de la clase "Data" 
en 1 cada vez que un objeto con el tag "Llave" colisiona con un objeto con un collider. 
Además se encarga de destruir el objeto "Llave" al momento de la colisión 
y mostrar la cantidad actual de llaves mediante un mensaje en la consola.
*/
public class Llave : MonoBehaviour
{
    
  void OnTriggerEnter(Collider other){
      Destroy(gameObject,0.00000000001f);
      Data.keys += 1;
      Debug.Log(Data.keys);
      
  }
}
