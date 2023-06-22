using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]

public class MainSound : MonoBehaviour
{
    public AudioSource Main;
    // Start is called before the first frame update
    void Start()
    {
        Main.playOnAwake = true;
        AudioSource audioSource = gameObject.AddComponent<AudioSource>();
        Main.loop = true;
    }
}
