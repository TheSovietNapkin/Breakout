using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_DatoCurioso : Bloque
{
    public List<string> comments = new List<string>()
{
    "Eres un sistema nervioso con una armadura de hueso y carne",
    "Si empieza a oler a cloro donde estas parado es porque un rayo va caer en ese lugar",
    "Si estas en un lugar poblado y cae dinero del cielo corre que es una tactica terrorista para atrear a màs gente en un lugar",
    "En el juego Wolfenstein the new Collosus sì ganas en la difultad Mein Lieben, todas las mujeres a 2 km a la redonda van a queres salir contigo",
    "La gente muere mas por culpa de las vacas que por tiburones, asi que ya metete al mar"
};
    // Start is called before the first frame update
    void Start()
    {
        int index = Random.Range(0, comments.Count);
        string randomComment = comments[index];
        Debug.Log(randomComment);
    }

    // Update is called once per frame
   
}
