using UnityEngine;
using System.Collections;

public class AudioPlay : MonoBehaviour
{
    public AudioSource auBackground;


    // Use this for initialization
    void Start()
    {   
        auBackground = GetComponent<AudioSource>();
        auBackground.Play();
    }

}
