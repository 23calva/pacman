﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPellet : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}