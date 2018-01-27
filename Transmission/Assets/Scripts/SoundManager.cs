using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{

    public AudioSource correctSound;
    public AudioSource wrongSound;
    public AudioSource musicSource;
    public static SoundManager instance = null;
    public float bpm = 128;

    SceneController scene;

    void Awake()
    {
        if(instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

    public void PlayCorrect()
    {
        correctSound.Play();
    }
    public void PlayWrong()
    {
        wrongSound.Play();
    }
}
