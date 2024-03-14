using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*
Controla una barra de "stamina". 
La barra de "stamina" se visualiza con un objeto Slider y se inicializa con un valor máximo igual al valor inicial de la energía.
El script monitorea el estado de la tecla Shift izquierda: si se presiona, disminuye la energía de la barra, 
y si se suelta, aumenta la energía de la barra. El valor actual de la energía se actualiza en cada frame y 
se refleja en la visualización de la barra de energía.
*/
public class StaminaBar : MonoBehaviour
{
    public float stamina;
    float maxStamina;
    public Slider staminaBar;
    public float dValue;

    // Start is called before the first frame update
    void Start()
    {
        maxStamina = stamina;
        staminaBar.maxValue =maxStamina;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift)){
            DecreaseEnergy();
        }else if(stamina!=maxStamina){
            IncreaseEnergy();
        }
        staminaBar.value=stamina;
    }

    private void DecreaseEnergy(){
        if(stamina!=0){
            stamina -= dValue * Time.deltaTime;
        }
    }

    private void IncreaseEnergy(){
        stamina += dValue * Time.deltaTime;
    }
}
