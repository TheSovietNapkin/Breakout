using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_MistaWhite : Bloque
{
    public string Bola;

    void Start()
    {
        resistencia = 2;
        if (resistencia <= 0)
        {
            Debug.Log("I am THE danger");

            GameObject prefab = Resources.Load<GameObject>(Bola);

            GameObject newObject = Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
}
