using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelletIgnore : MonoBehaviour
{
    private object Enemy;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Physics.IgnoreCollision(Enemy.collider, Collider);
        }
    }
}
