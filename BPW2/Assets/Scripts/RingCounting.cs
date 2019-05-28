using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingCounting : MonoBehaviour
{
    public AudioSource ringSound;

    void OnTriggerEnter(Collider other)
    {
        ringSound.Play();
        ScoreSystem.theScore += 100;
        Destroy(gameObject);
    }
}
