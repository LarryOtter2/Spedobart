using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    
    public static AudioManager Instance;

    public Sound[] musicSounds, sfxSounds, footstepSounds;
    public AudioSource musicSource, sfxSource, footstepsource;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        PlayMusic("BGM Desert");
    }

    #region Play
    public void PlayMusic(string name)
    {
        Sound s = Array.Find(musicSounds, x => x.name == name);

        if (s == null)
        {
            Debug.Log("Sound not Found");
        }
        else
        {
            musicSource.clip = s.clip;
            musicSource.Play();
        }
    }
    public void PlaySFX(string name)
    {
        Sound s = Array.Find(sfxSounds, x => x.name == name);

        if (s == null)
        {
            Debug.Log("Sfx not Found");
        }
        else
        {
            sfxSource.PlayOneShot(s.clip);
        }
    }
    public void PlayFootSteps(string name)
    {
        Debug.Log("Foot");
        Sound s = Array.Find(footstepSounds, x => x.name == name);

        if (s == null)
        {
            Debug.Log("Sound not Found");
        }
        else
        {
            footstepsource.clip = s.clip;
            footstepsource.Play();
        }
    }
    #endregion


    #region Stop
    public void StopMusic(string name)
    {
        Sound s = Array.Find(musicSounds, x => x.name == name);

        if (s == null)
        {
            Debug.Log("Sound not Found");
        }
        else
        {
            musicSource.clip = s.clip;
            musicSource.Stop();
        }
    }
    public void StopSFX(string name)
    {
        Sound s = Array.Find(sfxSounds, x => x.name == name);

        if (s == null)
        {
            Debug.Log("Sfx not Found");
        }
        else
        {
            musicSource.clip = s.clip;
            musicSource.Stop();
        }
    }
    
    #endregion





}
