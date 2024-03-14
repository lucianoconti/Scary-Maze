using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpcionesEntreEscenas : MonoBehaviour
{
    private void Awake(){
        var conservarEntreEscenas = FindObjectsOfType<OpcionesEntreEscenas>();
        if(conservarEntreEscenas.Length > 1){
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
