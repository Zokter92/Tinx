using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicClick : MonoBehaviour
{
    public AudioSource SonidoClick;
    public AudioClip SceneLoader;
    // Start is called before the first frame update
    void Start()
    {
        SonidoClick.clip = SceneLoader;
    }

    public void Reproducir()
    {
        SonidoClick.Play();
    }
}
