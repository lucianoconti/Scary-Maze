using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
/*
Este script se encarga de manejar el comportamiento del menú de juego, sobre 
la derrota y la victoria del jugador. En la función "Start", se busca el 
objeto jugador mediante la etiqueta "Player" y se establece el evento "MuerteJugador"
para activar el menú de Perdiste. En la función "ActivarMenuMuerte", se activa el objeto
del menú de Perdiste. También contiene otras funciones como "ActivarMenuVictoria" para mostrar el menu de victoria.

*/
public class Manejador : MonoBehaviour
{
        [SerializeField] private GameObject menuGameover;
        [SerializeField] private GameObject menuVictoria;
        private InfoJugador infoJugador;

        private void Start()
        {
            if(Time.timeScale==0)
            {
                Time.timeScale=1;
            }
            infoJugador = GameObject.FindGameObjectWithTag("Player").GetComponent<InfoJugador>();
            infoJugador.MuerteJugador += ActivarMenuMuerte;
        }

        private void ActivarMenuMuerte(object sender, EventArgs e)
        {
            menuGameover.SetActive(true);
        }
        private void ActivarMenuVictoria(object sender, EventArgs e)
        {
            menuVictoria.SetActive(true);
        }
        public void Cargarescena(string name){
            
            SceneManager.LoadScene(name);
        }

        public void ActivarMenuVictoria2(){
            menuVictoria.SetActive(true);
        }

        public void Salir(){
            Application.Quit();
        }


}
