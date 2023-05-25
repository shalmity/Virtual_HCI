using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SwordSound2 : MonoBehaviour
{
    public AudioClip swordSwingSound;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = swordSwingSound;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Target"))
        {
            audioSource.Play();
        }
    }
}
