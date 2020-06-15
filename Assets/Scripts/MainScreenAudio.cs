using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScreenAudio : MonoBehaviour
{

    public AudioSource MainAudio;
    // Start is called before the first frame update
    void Start()
    {
        MainAudio.Play();
        MainAudio.volume = 0.1f;
    }

}
