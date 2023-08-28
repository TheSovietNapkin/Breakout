using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuestraSubscriptor : MonoBehaviour
{


    MuestraEventos subsriptor;
    // Start is called before the first frame update
    void Start()
    {
        subsriptor = GetComponent<MuestraEventos>();
        subsriptor.EnCasoDeEspaciosPresionado += MensajeEscuchadoPorElSubsriptor;
    }

    // Update is called once per frame
    private void MensajeEscuchadoPorElSubsriptor (object sender, EventArgs e)
    {
        Debug.Log("El evebto ha sido escuchado desde otra clase");
        subsriptor.EnCasoDeEspaciosPresionado -= MensajeEscuchadoPorElSubsriptor;
    }
    
}
