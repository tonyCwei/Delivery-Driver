using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgmManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static AudioClip ingamepause;
    public static AudioClip ingamebgm;
    static AudioSource audioSrc;

    void Start()
    {
        ingamepause = Resources.Load<AudioClip>("ingamepause");
        ingamebgm = Resources.Load<AudioClip>("ingamebgm");
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string gamestate) {
        // switch(gamestate) {
        // case "ongoing":
        // audioSrc.Play(ingamebgm);
        // break;

        // case "pause":
        // audioSrc.Play(ingamepause);
        // break;
    }
    
}
