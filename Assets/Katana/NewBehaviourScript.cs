using UnityEngine;

public class SwordSound : MonoBehaviour
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
        if (other.CompareTag("Sword"))
        {
            audioSource.Play();
        }
    }
}
