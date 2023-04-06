using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip soundOnTriggerEnter;


    private void OnTriggerEnter(Collider other)
    {
        animator.Play("a_talking");
        transform.LookAt(other.transform);
        audioSource.clip = soundOnTriggerEnter;
        audioSource.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        audioSource.Stop();
        animator.Play("a_idle");
    }
}
