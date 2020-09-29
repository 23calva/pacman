using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed;

    void Start()
    {

    }

    void Update()
    {
        transform.Translate(new Vector3(0, 0, movementSpeed));

        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Rotate(new Vector3(0, -90, 0));
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Rotate(new Vector3(0, 90, 0));
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, -90, 0));
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 90, 0));
        }
    }
}