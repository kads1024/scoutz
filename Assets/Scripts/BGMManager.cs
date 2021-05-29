using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMManager : MonoBehaviour
{
    public static BGMManager Instance;

    public AudioClip MainMenuClip;
    public AudioClip MainGameClip;

    public AudioSource _audioSource;

    private void Awake()
    {
        if(!Instance)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }   
    }

    public void PlayAudio(bool isGame)
    {
        if(isGame)
        {
            if(_audioSource.clip != MainGameClip)
            {
                _audioSource.clip = MainGameClip;
                _audioSource.loop = true;
                _audioSource.Play();
            }     
        }
        else
        {
            _audioSource.clip = MainMenuClip;
            _audioSource.loop = true;
            _audioSource.Play();
        }
    }
}
