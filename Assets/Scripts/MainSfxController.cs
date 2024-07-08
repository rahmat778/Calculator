using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSfxController : MonoBehaviour
{
    public static MainSfxController Instance;
    public AudioSource ButtonAudio;

    private void Start()
    {
        Instance = this;
    }
    public void PlaySound()
    {
        ButtonAudio.Play();
    }
}
