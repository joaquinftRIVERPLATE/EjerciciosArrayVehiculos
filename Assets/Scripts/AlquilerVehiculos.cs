﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlquilerVehiculos : MonoBehaviour
{
    public GameObject[] vehiculos;

    // Start is called before the first frame update
    void Start()
    {
        ResetearVehiculos();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            DesactivcarTodosLosElementos();
            vehiculos[Random.Range(0, vehiculos.Length)].SetActive(true);
        }   
    }

    void ResetearVehiculos()
    {
        DesactivcarTodosLosElementos();
        vehiculos[0].SetActive(true);
    }
    void DesactivcarTodosLosElementos()
    {
        for (int i = 0; i < vehiculos.Length; i++)
        {
            vehiculos[i].SetActive(false);
        }
        
    }
}
