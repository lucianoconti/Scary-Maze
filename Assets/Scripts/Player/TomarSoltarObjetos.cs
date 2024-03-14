using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
Este script permite que el jugador pueda agarrar y soltar objetos. 
Cuando el jugador se acerca a un objeto que tenga la etiqueta "Objeto" y presiona la tecla "e", 
el objeto se recoge y se mueve hacia un punto de agarre designado. Cuando el jugador presiona la tecla "r", 
el objeto se suelta.El script utiliza dos puntos de agarre para el objeto, llamados HandPoint y HandPoint2 para reposicionarlo.
*/

public class TomarSoltarObjetos : MonoBehaviour
{
  public GameObject HandPoint;
  public GameObject HandPoint2;

  private GameObject pickedObject = null;
    void Update()
    {
        if (pickedObject!=null)
        {
            if(Input.GetKey("r"))
            {
                pickedObject.GetComponent<BoxCollider>().isTrigger = true;

                pickedObject.transform.position = HandPoint2.transform.position;
                pickedObject.gameObject.transform.SetParent(null);


                pickedObject = null;
             
            } 
        
        }

        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Objeto"))
        {
            if (Input.GetKey("e") && pickedObject == null)
            {
                other.GetComponent<Rigidbody>().useGravity = false;

                other.GetComponent<Rigidbody>().isKinematic = true;

                other.transform.position = HandPoint.transform.position;

                other.gameObject.transform.SetParent(HandPoint.gameObject.transform);   

                pickedObject = other.gameObject;     
            }
        
        }

        
    }



}
