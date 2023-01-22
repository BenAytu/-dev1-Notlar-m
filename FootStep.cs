using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootStep : MonoBehaviour
{
    [SerializeField] AudioClip[] audioClip;
    public AudioSource aS;
   
    private void Step ()
    {
        AudioClip clip = GetRandomClip();
        aS.PlayOneShot(clip);
    }

    private AudioClip GetRandomClip()
    {
        int index = Random.Range(0, audioClip.Length - 1);
        return audioClip[index];
    }
}
