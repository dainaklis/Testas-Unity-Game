using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip music1, music2, music3, shoot1, shoot2, hit1, hit2, dead, dead2, points;
    static AudioSource audioSrc;

    void Start()
    {
        music1 = Resources.Load<AudioClip>("Music1");
        music2 = Resources.Load<AudioClip>("Music2");
        music3 = Resources.Load<AudioClip>("Music3");

        shoot1 = Resources.Load<AudioClip>("Shoot1");
        shoot2 = Resources.Load<AudioClip>("Shoot2");
        hit1 = Resources.Load<AudioClip>("Hit1");
        hit2 = Resources.Load<AudioClip>("Hit2");
        dead = Resources.Load<AudioClip>("EnemyDeath");
        dead2 = Resources.Load<AudioClip>("PlayerDeath");

        points = Resources.Load<AudioClip>("Points");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "music1":
                audioSrc.PlayOneShot(music1);
                break;
            case "music2":
                audioSrc.PlayOneShot(music2);
                break;
            case "music3":
                audioSrc.PlayOneShot(music3);
                break;
            case "shoot1":
                audioSrc.PlayOneShot(shoot1);
                break;
            case "shoot2":
                audioSrc.PlayOneShot(shoot2);
                break;
            case "hit1":
                audioSrc.PlayOneShot(hit1);
                break;
            case "hit2":
                audioSrc.PlayOneShot(hit2);
                break;
            case "dead":
                audioSrc.PlayOneShot(dead);
                break;
            case "dead2":
                audioSrc.PlayOneShot(dead2);
                break;
            case "points":
                audioSrc.PlayOneShot(points);
                break;
            case "stop":
                audioSrc.Stop();
                break;
            
        }
    }
}
