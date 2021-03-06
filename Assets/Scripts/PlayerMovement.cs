﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
           transform.Translate(0, 0, -movementSpeed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, movementSpeed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(movementSpeed, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(-movementSpeed, 0, 0);
        }
    }
}