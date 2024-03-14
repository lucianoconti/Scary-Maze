using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
Este script crea una plataforma que cae cuando el jugador entra en contacto con ella. 
Cuando el jugador entra en contacto con la plataforma, la variable booleana isFalling se establece en verdadero.
En el método Update(), si isFalling es verdadero y la posición de la plataforma en el eje Y es mayor que -50, 
la velocidad de caída de la plataforma aumenta gradualmente y se actualiza la posición de la plataforma. 
Además, se invoca el método CooldownPlataforma() después de 20 segundos.
El método CooldownPlataforma() establece la variable isFalling en falso y devuelve la plataforma a su posición original en el eje Y.
*/


public class FallingPlatform : MonoBehaviour
{
    public bool isFalling = false;
    float downSpeed = 0;
    
    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.name == "Player")
            isFalling = true;
    }

    void Update()
    {
        if(isFalling && transform.position.y>-50)
        {
            downSpeed += Time.deltaTime/20;
            transform.position = new Vector3(transform.position.x,transform.position.y-downSpeed,transform.position.z);
        }  
        Invoke("CooldownPlataforma",20f);
    }

    void CooldownPlataforma()
    {
        isFalling = false;
        transform.position = new Vector3(transform.position.x,-12,transform.position.z);
    }
}


