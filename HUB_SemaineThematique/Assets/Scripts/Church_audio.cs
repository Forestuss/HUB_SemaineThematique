using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Church_audio : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip _sound;


    private void OnTriggerEnter(Collider other)
    {
        audioSource.clip = _sound;
        audioSource.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        audioSource.Stop();
    }
}