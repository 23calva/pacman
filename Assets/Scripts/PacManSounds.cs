using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacManSounds : MonoBehaviour
{
    public AudioClip sndPacDeath;

    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = sndPacDeath;
    }

    void OnCollisionEnter ()
    {
        GetComponent<AudioSource>().Play();
    }
    void Update()
    {
        
    }
}
