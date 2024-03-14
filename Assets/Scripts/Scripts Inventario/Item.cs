using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
Este script se utiliza para definir las propiedades de un objeto del juego, como un arma o una herramienta.
Cada objeto tiene un ID, un Tipo, una Descripción y un Icono que se usan para identificarlo en el inventario del jugador.
El script también tiene algunas variables adicionales, como "pickedUp" que se utiliza para indicar si el objeto ha sido recogido
por el jugador, "equipado" que indica si el objeto está actualmente en uso por el jugador, y "manejadorArma" que es un objeto utilizado
para gestionar todas las armas del juego.
En la función "Start()", el script busca en el "manejadorArma" el objeto correspondiente al ID del objeto y lo almacena en la variable "arma", 
si el objeto no es controlado por el jugador.
En la función "Update()", si el objeto está equipado y el jugador presiona la tecla "Q", se desequipa el objeto y se oculta en el juego.
La función "UsoItem()" se llama cuando el jugador usa el objeto. Primero, se busca y se desequipa cualquier otra arma que pueda estar 
equipada en ese momento. Luego, si el objeto es un "Hacha" o una "Antorcha", se equipa el objeto "arma" correspondiente y 
se marca como equipado.
*/

public class Item : MonoBehaviour
{
    public int ID;
    public string Tipo;
    public string Descripcion;
    public Sprite Icono;

    [HideInInspector]
    public bool pickedUp;
    [HideInInspector]
    public bool equipado;
    [HideInInspector]
    public GameObject manejadorArma;
    [HideInInspector]
    public GameObject arma;
    public GameObject auxArma;

    public bool armaJugador;


    private void Start()
    {
        manejadorArma=GameObject.FindGameObjectWithTag("ManejadorArma");

        if(!armaJugador)
        {
            int cantidadArmas= manejadorArma.transform.childCount;
            Debug.Log(cantidadArmas);

            for(int i=0;i<cantidadArmas;i++)
            {
                if(manejadorArma.transform.GetChild(i).gameObject.GetComponent<Item>().ID==ID)
                {
                    arma=manejadorArma.transform.GetChild(i).gameObject;
                }
            }
        }
    }

    private void Update()
    {
        if(equipado)
        {
            if(Input.GetKeyDown(KeyCode.Q))
            {
                equipado=false;
            }
            if(equipado==false)
            {
                gameObject.SetActive(false);
            }
        }
    }

    public void UsoItem()
    {   int cantidadArmas= manejadorArma.transform.childCount;
        for(int i=0;i<cantidadArmas;i++)
            {   
                auxArma=manejadorArma.transform.GetChild(i).gameObject;
                if(auxArma.GetComponent<Item>().equipado==true)
                {
                    auxArma.SetActive(false);
                    auxArma.GetComponent<Item>().equipado=false;
                }
            }
        if(Tipo=="Hacha" || Tipo =="Antorcha")
        {
            arma.SetActive(true);
            arma.GetComponent<Item>().equipado=true;
        }
        

        

    }

}
