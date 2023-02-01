using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static AudioClip pickUp, deliver, boost;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        pickUp = Resources.Load<AudioClip> ("pickUp");
        deliver = Resources.Load<AudioClip> ("deliver");
        boost = Resources.Load<AudioClip> ("boost");
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public static void PlaySound(string clip) 
    {
       switch(clip) {
        case "pickUp":
        audioSrc.PlayOneShot(pickUp);
        break;

        case "deliver":
        audioSrc.PlayOneShot(deliver);
        break;

        case "boost":
         audioSrc.PlayOneShot(boost);
         break;

       }
 



    }
}
