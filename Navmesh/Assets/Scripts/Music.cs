using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    
    private AudioSource _audioSource;
   

    public void PlayMusic()
    {
        if (!_audioSource.isPlaying)
            _audioSource.Play();
    }
    

   

    
}
