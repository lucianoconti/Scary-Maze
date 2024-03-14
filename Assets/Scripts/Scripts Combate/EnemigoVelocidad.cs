using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemigoVelocidad : MonoBehaviour
{
    public Transform Objetivo;
    public Transform Objetivo2;
    public float Velocidad;
    public float IncrementoVelocidad;
    public float Tiempo;
    public float lapsoNivel;
    public float incrementoLapsoNivel;
    public NavMeshAgent IA;
    public bool aux=true;

    public Animation Anim;

    public string NombreAnimacionCaminar;
    public string NombreAnimacionAtack;
    // Update is called once per frame
    void Update()
    {   if(aux){
        IA.speed = Velocidad;
        IA.SetDestination(Objetivo.position);
        }   
        if (IA.velocity == Vector3.zero)
        {
            Anim.CrossFade(NombreAnimacionAtack);
            Velocidad += IncrementoVelocidad; 
        }
        else
        {
            Anim.CrossFade(NombreAnimacionCaminar);
        }
    }

    private void OnTriggerEnter(Collider other){
         if(other.tag=="Item"){
         aux=false;
         IA.SetDestination(Objetivo2.position);
         }else if(other.tag=="PuntoRegreso"){
            aux=true;
         }
    }

    void aumentoVelocidad(){
        Tiempo = Time.time;
    if (Time.time > lapsoNivel){
        Velocidad += IncrementoVelocidad;
        lapsoNivel += incrementoLapsoNivel;
        }
     }
}
