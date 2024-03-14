using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
Controlar el timer en el juego que aparece en la pantalla en formato de minutos y segundos.
Comienza con una cantidad específica de minutos y segundos,
y el tiempo restante se actualiza continuamente. 
Cuando se agota el tiempo, la variable "conTiempo" se establece en falso y la cuenta atrás se detiene.
*/

public class TimeController : MonoBehaviour
{
    [SerializeField] int min,seg;
    [SerializeField] Text tiempo;

    private float restante;
    public bool  conTiempo;

    // Start is called before the first frame update
    private void Awake(){
        restante = (min * 60) + seg;
        conTiempo=true;

    }

    // Update is called once per frame
    void Update()
    {
        if(conTiempo)
        {
            restante -= Time.deltaTime;
            if(restante < 1)
            {
                conTiempo=false;
                

            }
            int tempMin = Mathf.FloorToInt(restante / 60);
            int tempSeg = Mathf.FloorToInt(restante % 60);
            tiempo.text = string.Format("{00:00}:{01:00}",tempMin,tempSeg);
        }
        
    }
}







