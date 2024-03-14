using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UltimoTerrenoTocado : MonoBehaviour
{
    private string ultimoTerrenoTocado = "ZonaInicial";
    public string Nombre(){
        return ultimoTerrenoTocado;
    }

    private void OnCollisionEnter (Collision collisionInfo){
        if (collisionInfo.collider.tag == "Terreno") {
            ultimoTerrenoTocado = collisionInfo.collider.name;
        }
    }        
}
