using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
/*
El objetivo de este script es permitir al jugador pausar y despausar el juego presionando una tecla, 
y también regresar al menú principal desde la escena actual. También controla la aparicion del botón de 
"Regresar" cuando se pausa el juego y se encuentra en la escena del menú.

*/
public class Pausa : MonoBehaviour
{
    public Button botonRegresar;
    public Scene currentScene;
    bool pausado = false;

    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        botonRegresar.onClick.AddListener(DespausarJuego);
    }

    void Update()
    {
        if(currentScene.name=="Menu")
        {
            botonRegresar.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (pausado)
            {
                DespausarJuego();
            }
            else
            {
                PausarJuego();
            }
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pausado)
            {
                DespausarJuego();
            }
            else
            {
                PausarJuego();
            }
        }
    }

    public void PausarJuego()
    {
        Time.timeScale = 0;
        botonRegresar.gameObject.SetActive(true);
        pausado = true;
    }

    public void DespausarJuego()
    {
        botonRegresar.gameObject.SetActive(false);
        pausado = false;
    }
}