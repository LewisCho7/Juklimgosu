using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static SoundManager Instance { get; private set; }
    public AudioSource mainBGM;
    public AudioSource deadSFX;

    private void Awake()
    {
        Instance = this;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playSFX();
        }
    }
    public void playMainBGM()
    {
        mainBGM.Play();
    }
    public void stopMainBGM()
    {
        mainBGM.Stop();
    }

    public void playSFX()
    {
        deadSFX.Play();   
    }
    public void stopSFX()
    {
        deadSFX.Stop();
    }
}
