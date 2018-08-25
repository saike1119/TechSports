using UnityEngine;
using System.Collections;

public class Sound : MonoBehaviour
{
    public AudioClip audioClip1;
    public AudioClip audioClip2;
    public AudioClip audioClip3;
    private AudioSource audioSource;

    public Sound()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = audioClip1;
    }

    public void playSound(){
        audioSource.PlayOneShot(audioClip1);
    }
}