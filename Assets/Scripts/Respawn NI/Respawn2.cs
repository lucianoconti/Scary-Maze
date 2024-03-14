using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn2 : MonoBehaviour {
   
    //punto de respawn
    public Transform inicial; 
    public Transform final;

    private UltimoTerrenoTocado ultimoTerrenoTocado; //ultima plataforma que tocó el jugador


    public void Reposicionar (string nuevaPosicion) {
        switch (nuevaPosicion) {
            case "ZonaInicial":
                transform.position = inicial.position;
                break;
            case "ZonaFinal":
                transform.position = final.position;
                break;
            default:
                transform.position = inicial.position;
                break;
        }

    }

    private void Start () {
        ultimoTerrenoTocado = GetComponent<UltimoTerrenoTocado>();
    }


    void OnTriggerEnter(Collider other) {
        if(other.tag == "Respawn") {
            Reposicionar(ultimoTerrenoTocado.Nombre());
        }

    }

}