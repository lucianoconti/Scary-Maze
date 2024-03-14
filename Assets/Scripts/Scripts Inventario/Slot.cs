using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
/*
Este script define el comportamiento de un slot en el inventario del juego.
Un slot es un espacio que puede contener un objeto en el inventario. 
El script define varias propiedades de un slot, como el objeto que contiene, su ID, tipo, descripción, si está vacío, y su icono.
El método "Start" se encarga de obtener el objeto hijo que representa el icono del slot. 
El método "UpdateSlot" actualiza el icono del slot con el icono del objeto que contiene.
El método "UsarItem" llama al método "UsoItem" del objeto que está contenido en el slot. 
Este método está diseñado para permitir el uso del objeto desde el inventario.
Finalmente, el método "OnPointerClick" se activa cuando se hace clic en el slot, lo que llama al método "UsarItem" para usar el objeto.
*/

public class Slot : MonoBehaviour, IPointerClickHandler
{
    public GameObject item;
    public int ID;
    public string Tipo;
    public string Descripcion;
    
    public bool empty;
    public Sprite Icono;
    
    public Transform slotIconGameObject;

    public void Start(){
        slotIconGameObject = transform.GetChild(0);
    }

    public void UpdateSlot(){
        slotIconGameObject.GetComponent<Image>().sprite= Icono;
    }

    public void UsarItem()
    {
        item.GetComponent<Item>().UsoItem();
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        UsarItem();
    }
}
