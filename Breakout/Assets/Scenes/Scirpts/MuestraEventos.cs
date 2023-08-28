using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MuestraEventos : MonoBehaviour
{

    public UnityEvent MiEventoUnity;
    public event EventHandler EnCasoDeEspaciosPresionado;
    // Start is called before the first frame update
    void Start()
    {
        EnCasoDeEspaciosPresionado += EventosEscuchado;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            EnCasoDeEspaciosPresionado?.Invoke(this, EventArgs.Empty);
            MiEventoUnity.Invoke();
        }
    }
    
    public void EventosEscuchado (object sender, EventArgs e)
    {
        Debug.Log("el evento se escucho correctamente");
    }    

    public void EventoUnityDisparado()
    {
        Debug.Log("El evento Unity se ha disparado");
    }

}
