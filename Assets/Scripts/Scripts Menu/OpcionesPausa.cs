﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpcionesPausa : MonoBehaviour
{
    public ControladorOpciones panelOpciones;
    // Start is called before the first frame update
    void Start()
    {
        panelOpciones = GameObject.FindGameObjectWithTag("Opciones").GetComponent<ControladorOpciones>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            MostrarOpciones();
        }
    }

    public void MostrarOpciones(){
        panelOpciones.pantallaOpciones.SetActive(true);
    }
}
