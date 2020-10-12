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

    //void OnCollisionEnter ()
    //{
    //    if (other.gameObject.CompareTag("Pickup"))
    //    {
    //        other.gameObject.SetActive(false);
    //    }
    //    GetComponent<AudioSource>().Play();
    //}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            GetComponent<AudioSource>().Play();
            Debug.Log("Hit Enemy");
        }
    }
    void Update()
    {
        
    }
}
