﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detecciondecoliciones : MonoBehaviour
{
   
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Contacto");
        Destroy(collision.gameObject);
    }
}
