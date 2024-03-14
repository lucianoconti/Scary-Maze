using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectaPlayer : MonoBehaviour
{
    public Transform enemigo;
    public Transform player;
    public float velocidad;
    public Animation Anim;
    public string NombreAnimacionCaminar;
    public string NombreAnimacionAtack;
    public string NombreAnimacionReposo;

    private bool activo;
    private Vector3 playerPosicion;

    private void Update()
    {
        playerPosicion = new Vector3(player.position.x,enemigo.position.y,player.position.z);
        Anim.CrossFade(NombreAnimacionReposo);

        if(activo==true)
        {
            enemigo.transform.position = Vector3.MoveTowards(transform.position, playerPosicion, velocidad * Time.deltaTime);
            enemigo.transform.LookAt(playerPosicion);
            Anim.CrossFade(NombreAnimacionCaminar);
        }

        if(Vector3.Distance(enemigo.transform.position,player.transform.position)< 1.5f){
           Anim.CrossFade(NombreAnimacionAtack);
        }
    }        

    private void OnTriggerEnter (Collider other)
    {
       if(other.tag=="Player")
       {
         activo = true;
       }
    }
    private void OnTriggerExit (Collider other)
    {
       if(other.tag=="Player")
       {
         activo = false;
       }
    }

}
