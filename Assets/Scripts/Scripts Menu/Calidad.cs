using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Calidad : MonoBehaviour
{
    public Dropdown dropdown;
    public int calidad;

    // Start is called before the first frame update
    void Start()
    {
        calidad = PlayerPrefs.GetInt("numeroCalidad",2);
        dropdown.value = calidad;
        AjustarCalidad();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AjustarCalidad(){

        QualitySettings.SetQualityLevel(dropdown.value);
        PlayerPrefs.SetInt("numeroCalidad",dropdown.value);
        calidad = dropdown.value;
    }
}
