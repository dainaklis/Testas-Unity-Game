using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusicButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayMusic1()
    {
        SoundManager.PlaySound("music1");
    }

    public void PlayMusic2()
    {
        SoundManager.PlaySound("music2");
    }
    public void PlayMusic3()
    {
        SoundManager.PlaySound("music3");
    }

    public void StopMusic()
    {
        SoundManager.PlaySound("stop");
    }
}
