using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;

    void Update()
    {
        Instantiate(enemy, transform.position, transform.rotation);
    }
}