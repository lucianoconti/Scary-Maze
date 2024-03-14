using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
Este script controla el estado de un objeto en el juego, en este caso una plataforma, 
haciendo que se active y desactive en intervalos regulares de tiempo. 
El script tiene una variable pública que representa la plataforma que se va a cambiar, 
y otra variable pública que representa el tiempo que se tardará en cambiar el estado del objeto.
El método Start() llama a un método llamado ChangeObjetState() repetidamente en un intervalo de tiempo
definido por la variable CambioTiempo. Este método simplemente cambia el estado de la plataforma de activo
a inactivo y viceversa, utilizando el método SetActive() de Unity.
*/

public class SwitchState : MonoBehaviour
{
    public GameObject Plataforma;
    public float CambioTiempo;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ChangeObjetState", 0f, CambioTiempo);
    }
    void ChangeObjetState()
    {
        Plataforma.SetActive(!Plataforma.activeInHierarchy);
    }

}
