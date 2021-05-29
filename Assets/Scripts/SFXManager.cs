using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public static SFXManager Instance;

    public List<AudioClip> Footstep;
    public AudioClip Pickup;

    public AudioSource _audioSource;

    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
    }

    public void PlayFootStep()
    {
        _audioSource.clip = Footstep[Random.Range(0, Footstep.Count)];
        _audioSource.loop = false;
        _audioSource.Play();
    }

    public void PlayPickup()
    {
        _audioSource.clip = Pickup;
        _audioSource.loop = false;
        _audioSource.Play();
    }
}
