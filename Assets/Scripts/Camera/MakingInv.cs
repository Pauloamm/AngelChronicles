﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakingInv : MonoBehaviour
{
    [SerializeField]
    GameObject LighHouseExterior;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            LighHouseExterior.GetComponent<MeshRenderer>().material.SetFloat("_Alpha", (0));
        }
    }
}
