using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cont : MonoBehaviour {
  
    public Text planetNameText;
    public AudioSource audioSource;
    public AudioClip mercuryClip;
    public AudioClip venusClip;
    public AudioClip earthClip;
    public AudioClip marsClip;
    public AudioClip jupiterClip;
    public AudioClip saturnClip;
    public AudioClip uranusClip;
    public AudioClip neptuneClip;
    public AudioClip plutoClip;

    public void ShowMercury()
    {
        planetNameText.text = "Mercury";
        PlayMusic(mercuryClip);
    }

    public void ShowVenus()
    {
        planetNameText.text = "Venus";
        PlayMusic(venusClip);
    }

    public void ShowEarth()
    {
        planetNameText.text = "Earth";
        PlayMusic(earthClip);
    }

    public void ShowMars()
    {
        planetNameText.text = "Mars";
        PlayMusic(marsClip);
    }

    public void ShowJupiter()
    {
        planetNameText.text = "Jupiter";
        PlayMusic(jupiterClip);
    }

    public void ShowSaturn()
    {
        planetNameText.text = "Saturn";
        PlayMusic(saturnClip);
    }

    public void ShowUranus()
    {
        planetNameText.text = "Uranus";
        PlayMusic(uranusClip);
    }

    public void ShowNeptune()
    {
        planetNameText.text = "Neptune";
        PlayMusic(neptuneClip);
    }
    public void ShowPluto()
    {
        planetNameText.text = "Pluto";
        PlayMusic(plutoClip);
    }
    private void PlayMusic(AudioClip clip)
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }
        audioSource.clip = clip;
        audioSource.Play();
    }


}
