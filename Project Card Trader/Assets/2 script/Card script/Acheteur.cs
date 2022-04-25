using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acheteur : MonoBehaviour
{
    [Header("valeurs pnj")]
    public int joie;
    public int colere;

    void Start()
    {
        joie = Random.Range(35, 101);
        colere = Random.Range(0, 101);
    }

    
    void Update()
    {
        print(joie);
        print(colere);
    }
}
