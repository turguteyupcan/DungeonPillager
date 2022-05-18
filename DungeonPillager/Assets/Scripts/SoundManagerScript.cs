using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip jump, death, run;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        jump = Resources.Load<AudioClip>("jump");
        death = Resources.Load<AudioClip>("death");
        run = Resources.Load<AudioClip>("running");

        audioSrc = GetComponent<AudioSource>();
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "jump":
                audioSrc.PlayOneShot(jump);
                break;
            case "death":
                audioSrc.PlayOneShot(death);
                break;
            case "run":
                audioSrc.PlayOneShot(run);
                break;
            default:
                break;
        }
    }
}
