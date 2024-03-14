using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
Este script se encarga de manejar un inventario del juego.
 Cuando se presiona la tecla "I", el inventario se activa o desactiva. 
 Si el jugador entra en contacto con un objeto con el tag "Item", el objeto se añade al inventario. 
 El inventario consta de un número determinado de espacios (slots) y cada espacio puede contener un objeto.

El script primero busca y almacena todos los slots del inventario en un array.
Luego, cuando el jugador recoge un objeto, el objeto se coloca en el primer espacio disponible 
en el inventario y se desactiva hasta que se necesite nuevamente.
Cuando se activa el inventario, se muestra en la pantalla y cuando se desactiva, se oculta. 
Además, cuando el inventario está activado, el cursor del mouse es visible y se puede mover libremente, 
pero cuando se desactiva, el cursor se bloquea y se oculta.

*/

public class Inventario : MonoBehaviour
{
    private bool InventarioEnabled;

    public GameObject inventario;

    private int allSlots;

    private int enabledSlots;

    private GameObject[] slot;

    public GameObject slotHolder;



    void Start()
    {
       allSlots = slotHolder.transform.childCount; 

       slot = new GameObject[allSlots];

       for (int i = 0; i < allSlots; i++)
       {
        slot[i]= slotHolder.transform.GetChild(i).gameObject;
        if(slot[i].GetComponent<Slot>().item==null){
            slot[i].GetComponent<Slot>().empty=true;
        }
       } 
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            InventarioEnabled = !InventarioEnabled;
            if (InventarioEnabled)
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }

        if (InventarioEnabled)
        {
            inventario.SetActive(true);
        }
        else
        {
            inventario.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other){
        if(other.tag=="Item"){
            GameObject itemPickedUp = other.gameObject;
            Item item =itemPickedUp.GetComponent<Item>();

            AddItem(itemPickedUp,item.ID,item.Tipo,item.Descripcion,item.Icono);
        }
    }

    public void AddItem(GameObject itemObject, int itemID, string itemTipo, string itemDescripcion, Sprite itemIcono){
        for(int i=0;i<allSlots;i++){
            if(slot[i].GetComponent<Slot>().empty){
                itemObject.GetComponent<Item>().pickedUp = true;
                slot[i].GetComponent<Slot>().item = itemObject;
                slot[i].GetComponent<Slot>().ID = itemID;
                slot[i].GetComponent<Slot>().Tipo = itemTipo;
                slot[i].GetComponent<Slot>().Descripcion = itemDescripcion;
                slot[i].GetComponent<Slot>().Icono = itemIcono;

                itemObject.transform.parent = slot[i].transform;
                itemObject.SetActive(false);

                slot[i].GetComponent<Slot>().UpdateSlot();
                slot[i].GetComponent<Slot>().empty=false;
                return;
            }
        }
    }
}