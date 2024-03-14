using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosEnemigo : MonoBehaviour
{
   public int vida = 100;
   
   void Update(){

       if (vida == 0)
       {
          Destroy(gameObject,0.1f);
       }
   }
}


