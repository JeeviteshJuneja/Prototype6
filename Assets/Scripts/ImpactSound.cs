using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactSound : MonoBehaviour
{
    private AudioSource impactSound;

    private void Awake()
    {
        impactSound = gameObject.GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude > 7)
        {
            impactSound.Play();
        }
    }
}
